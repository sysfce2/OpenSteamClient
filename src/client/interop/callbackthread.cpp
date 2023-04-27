#include "callbackthread.h"
#include "../ext/steamclient.h"
#include "generated_callbacklist.h"

std::string CallbackThread::ThreadName() {
    return "CallbackThread";
}
void CallbackThread::ThreadMain() {

    std::cout << "ThreadMain calleddded" << std::endl;
    CallbackMsg_t callBack;
    do
    {
        Global_SteamClientMgr->ClientEngine->RunFrame();
        if (Global_SteamClientMgr->Steam_BGetCallback( Global_SteamClientMgr->pipe, &callBack )) {               
            if (Global_debugCbLogging) {
                if (callbacks.contains(callBack.m_iCallback)) {
                    DEBUG_MSG << "Received callback [ID: " << callBack.m_iCallback << ", name: " << callbacks[callBack.m_iCallback] << " binary params(len: " << callBack.m_cubParam << "): " << callBack.m_pubParam << "]" << std::endl;
                } else {
                    DEBUG_MSG << "Received callback [ID: " << callBack.m_iCallback << ", binary params: " << callBack.m_pubParam << "]" << std::endl;
                }
                
            }

            switch (callBack.m_iCallback)
            {
                case SteamServerConnectFailure_t::k_iCallback:
                {
                	SteamServerConnectFailure_t *pConnectFailureInfo = (SteamServerConnectFailure_t *)callBack.m_pubParam;
                    if (pConnectFailureInfo->m_eResult == k_EResultNoConnection) {
                        // transparently retry and don't tell the user
                        Global_SteamClientMgr->ClientUser->BInitiateReconnect();
                        return;
                    }
                    emit SteamServerConnectFailure(*pConnectFailureInfo);
                    break;
                }
                case SteamServersConnected_t::k_iCallback:
                {
                    SteamServersConnected_t *info = (SteamServersConnected_t *)callBack.m_pubParam;
                    emit SteamServersConnected(*info);
                    break;
                }
                case AppLicensesChanged_t::k_iCallback:
                {
                    AppLicensesChanged_t *info = (AppLicensesChanged_t *)callBack.m_pubParam;
                    emit AppLicensesChanged(*info);
                    break;
                }
                case PostLogonState_t::k_iCallback:
                {
                    PostLogonState_t *info = (PostLogonState_t *)callBack.m_pubParam;
                    DEBUG_MSG << "unk1: " << info->unk1 << std::endl;
                    DEBUG_MSG << "unk2: " << info->unk2 << std::endl;
                    DEBUG_MSG << "unk3: " << info->unk3 << std::endl;
                    DEBUG_MSG << "logonComplete: " << info->logonComplete << std::endl;
                    DEBUG_MSG << "unk5: " << info->unk5 << std::endl;
                    emit PostLogonState(*info);
                    break;
                }
                case CheckAppBetaPasswordResponse_t::k_iCallback:
                {
                    CheckAppBetaPasswordResponse_t *info = (CheckAppBetaPasswordResponse_t *)callBack.m_pubParam;
                    DEBUG_MSG << "appid: " << info->appid << std::endl;
                    DEBUG_MSG << "eresult: " << info->eResult << std::endl;
                    emit CheckAppBetaPasswordResponse(*info);
                    break;
                }
                // 1280006 means download progress, len 16
                // 1280018 means download finished, length 16

            default:
                break;
            }
            

            Global_SteamClientMgr->Steam_FreeLastCallback(Global_SteamClientMgr->pipe);
        } else {
            std::this_thread::sleep_for(std::chrono::milliseconds(10));
        }
    } while (!shouldStop);
}
void CallbackThread::StopThread() {
    this->shouldStop = true;
}
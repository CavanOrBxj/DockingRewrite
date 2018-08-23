using System.Threading;
using System.Collections.Generic;
using System.Data;

namespace GRPlatForm
{
    public class SingletonInfo
    {
        private static SingletonInfo _singleton;


        /// <summary>
        /// 经度
        /// </summary>
        public string Longitude;
        /// <summary>
        /// 纬度
        /// </summary>
        public string Latitude;


        public string PlayRecordLastTime;

        public string TsCmd_ValueID_;

        public string sZJPostUrlAddress;
        public string TerminalLastTime;

        public bool PlatformInformationFirst;

        public int SequenceCodes;//顺序码
        private SingletonInfo()                                                                 
        {
            Longitude = "";
            Latitude = "";
            PlayRecordLastTime = "";

            //终端
            TerminalLastTime = "";
            TsCmd_ValueID_ = "";
            sZJPostUrlAddress = "";
            PlatformInformationFirst = false;
            SequenceCodes = 0;
        }
        public static SingletonInfo GetInstance()
        {
            if (_singleton == null)
            {
                Interlocked.CompareExchange(ref _singleton, new SingletonInfo(), null);
            }
            return _singleton;
        }
    }
}
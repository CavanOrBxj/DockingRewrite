using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GRPlatForm
{
   public  class PlayElements
    {

        public EBD EBDITEM { get; set; }
        public string sAnalysisFileName { get; set; }
        public string xmlFilePath { get; set; }


        public string targetPath { get; set; }
    }



    public class OrganizationInfo
    {
        /// <summary>
        /// 区域名称
        /// </summary>
        public string ORG_DETAIL { get; set; }

        /// <summary>
        /// 区域码
        /// </summary>
        public string GB_CODE { get; set; }
    }


}

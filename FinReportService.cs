using System;
using System.Collections.Generic;
using System.Web.Services;
namespace FinReportWebService
{

    public class FinReportService

    {
        private readonly List<FinReport> _finReports;
        private readonly int[] ids = new int[] { 357, 358, 360, 361 };
        private readonly string[] lorems = new string[] { "Integer gravida quis felis ut.",
            "Vivamus accumsan, purus non tempor.",
        "Maecenas faucibus consequat dolor non.",
        "Proin libero velit, pharetra vitae."};
        public FinReportService()
        {
            _finReports = new List<FinReport>();

            for (int i = 0; i < 4; i++)
            {
                _finReports.Add(new FinReport
                {
                    ReportID = ids[i],
                    Date = DateTime.Today,
                    Info = lorems[i]
                });
            }
        }


        [WebMethod]
        public int[] GetReportIdArray(DateTime dateBegin, DateTime dateEnd)
        {

            return ids;
        }

        [WebMethod]
        public FinReport GetReport(int reportID)
        {
            foreach (FinReport report in _finReports)
            {
                if (report.ReportID == reportID)
                {
                    return report;
                }
            }

            return null;
        }
    }

    public class FinReport
    {
        public int ReportID { get; set; }
        public DateTime Date { get; set; }
        public string Info { get; set; }
    }
}
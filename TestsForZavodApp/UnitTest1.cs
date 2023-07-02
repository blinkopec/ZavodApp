using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Windows.Controls;
using ZavodApp;
using ZavodApp.WorkerResources.Pages;
using ZavodApp.WorkerResources.Pages.PagesForWork;

namespace TestsForZavodApp
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            ReportCard rc23 = new ReportCard()
            {
                idDetail = 1,
                idWorker = 1,
                numberOfDetails = 32,
                date = new DateTime(23),
                workingTime = 3
            };


            ZavodPracticeEntities.GetContext().ReportCard.Add(rc23);
            ZavodPracticeEntities.GetContext().SaveChanges();

            ReportCard rc = ZavodPracticeEntities.GetContext().ReportCard.Find(rc23);
            Assert.IsNotNull(rc);
            Assert.AreEqual(rc23.idReportCard, rc.idReportCard);
            Assert.AreEqual(rc23.idWorker, rc.idWorker);
            Assert.AreEqual(rc23.workingTime, rc.workingTime);
            Assert.AreEqual(rc23.date, rc.date);
            Assert.AreEqual(rc23.numberOfDetails, rc.numberOfDetails);
            Assert.AreEqual(rc23.idDetail, rc.idDetail);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using BodyMedia.CoreClient.Entities;

namespace BodyMedia.CoreClient.Tests.StepTests
{
    [TestFixture]
    public class BodyMediaExample1SerializaionTests : BaseSerializationTest
    {
        private const string _xmlPath = "BodyMedia.CoreClient.Tests.ExampleXml.Step_Example1.xml";

        [Test]
        public void GIVEN_BodyMedia_Example_XML_WHEN_deserialized_THEN_there_should_not_be_an_exception()
        {
            TestSerialization<Step>(_xmlPath, x =>
            {
            });
        }

        [Test]
        public void GIVEN_BodyMedia_Example_XML_WHEN_deserialized_THEN_the_result_should_not_be_null()
        {
            TestSerialization<Step>(_xmlPath, x =>
            {
                Assert.IsNotNull(x);
            });
        }

        [Test]
        public void GIVEN_BodyMedia_Example_XML_WHEN_deserialized_THEN_the_result_should_have_an_averageSteps_of_12652()
        {
            TestSerialization<Step>(_xmlPath, x =>
            {
                Assert.AreEqual(12652, x.AverageSteps);
            });
        }

        [Test]
        public void GIVEN_BodyMedia_Example_XML_WHEN_deserialized_THEN_the_result_should_have_an_totalSteps_of_12652()
        {
            TestSerialization<Step>(_xmlPath, x =>
            {
                Assert.AreEqual(12652, x.TotalSteps);
            });
        }

        [Test]
        public void GIVEN_BodyMedia_Example_XML_WHEN_deserialized_THEN_the_result_should_have_a_start_date_of_20110615()
        {
            TestSerialization<Step>(_xmlPath, x =>
            {
                Assert.AreEqual(new DateTime(2011, 6, 15), x.StartDate);
            });
        }

        [Test]
        public void GIVEN_BodyMedia_Example_XML_WHEN_deserialized_THEN_the_result_should_have_an_end_date_of_20110615()
        {
            TestSerialization<Step>(_xmlPath, x =>
            {
                Assert.AreEqual(new DateTime(2011, 6, 15), x.EndDate);
            });
        }

        [Test]
        public void GIVEN_BodyMedia_Example_XML_WHEN_deserialized_THEN_the_result_should_have_a_non_null_LastSync()
        {
            TestSerialization<Step>(_xmlPath, x =>
            {
                Assert.IsNotNull(x.LastSync);
            });
        }

        [Test]
        public void GIVEN_BodyMedia_Example_XML_WHEN_deserialized_THEN_the_result_should_have_a_LastSync_TimeStamp_of_20120621T151047_1000()
        {
            TestSerialization<Step>(_xmlPath, x =>
            {
                Assert.AreEqual(new DateTime(2012, 6, 21, 15, 10, 47).AddHours(6), x.LastSync.TimeStamp);
            });
        }

        [Test]
        public void GIVEN_BodyMedia_Example_XML_WHEN_deserialized_THEN_the_result_should_have_a_LastSync_Type_of_UPLOAD_SYNC_WIN()
        {
            TestSerialization<Step>(_xmlPath, x =>
            {
                Assert.AreEqual("UPLOAD_SYNC_WIN", x.LastSync.Type);
            });
        }

        [Test]
        public void GIVEN_BodyMedia_Example_XML_WHEN_deserialized_THEN_the_result_should_have_a_non_null_days_collection()
        {
            TestSerialization<Step>(_xmlPath, x =>
            {
                Assert.IsNotNull(x.StepDays);
            });
        }

        [Test]
        public void GIVEN_BodyMedia_Example_XML_WHEN_deserialized_THEN_the_result_should_have_a_days_collection_with_0_elements()
        {
            TestSerialization<Step>(_xmlPath, x =>
            {
                Assert.AreEqual(0, x.StepDays.Length);
            });
        }
    }
}

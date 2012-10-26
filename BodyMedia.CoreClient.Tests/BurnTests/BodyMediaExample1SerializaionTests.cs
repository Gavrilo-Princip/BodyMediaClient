using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using BodyMedia.CoreClient.Entities;

namespace BodyMedia.CoreClient.Tests.BurnTests
{
    [TestFixture]
    public class BodyMediaExample1SerializaionTests : BaseSerializationTest
    {
        private const string _xmlPath = "BodyMedia.CoreClient.Tests.ExampleXml.Burn_Example1.xml";

        [Test]
        public void GIVEN_BodyMedia_Example_XML_WHEN_deserialized_THEN_there_should_not_be_an_exception()
        {
            TestSerialization<Burn>(_xmlPath, x =>
            {
            });
        }

        [Test]
        public void GIVEN_BodyMedia_Example_XML_WHEN_deserialized_THEN_the_result_should_not_be_null()
        {
            TestSerialization<Burn>(_xmlPath, x =>
            {
                Assert.IsNotNull(x);
            });
        }

        [Test]
        public void GIVEN_BodyMedia_Example_XML_WHEN_deserialized_THEN_the_result_should_have_a_averageCalories_of_3501()
        {
            TestSerialization<Burn>(_xmlPath, x =>
            {
                Assert.AreEqual(3501, x.AverageCalories);
            });
        }

        [Test]
        public void GIVEN_BodyMedia_Example_XML_WHEN_deserialized_THEN_the_result_should_have_a_totalCalories_of_3501()
        {
            TestSerialization<Burn>(_xmlPath, x =>
            {
                Assert.AreEqual(3501, x.TotalCalories);
            });
        }

        [Test]
        public void GIVEN_BodyMedia_Example_XML_WHEN_deserialized_THEN_the_result_should_have_a_start_date_of_20110615()
        {
            TestSerialization<Burn>(_xmlPath, x =>
            {
                Assert.AreEqual(new DateTime(2011, 6, 15), x.StartDate);
            });
        }

        [Test]
        public void GIVEN_BodyMedia_Example_XML_WHEN_deserialized_THEN_the_result_should_have_an_end_date_of_20110615()
        {
            TestSerialization<Burn>(_xmlPath, x =>
            {
                Assert.AreEqual(new DateTime(2011, 6, 15), x.EndDate);
            });
        }

        [Test]
        public void GIVEN_BodyMedia_Example_XML_WHEN_deserialized_THEN_the_result_should_have_a_non_null_LastSync()
        {
            TestSerialization<Burn>(_xmlPath, x =>
            {
                Assert.IsNotNull(x.LastSync);
            });
        }

        [Test]
        public void GIVEN_BodyMedia_Example_XML_WHEN_deserialized_THEN_the_result_should_have_a_LastSync_TimeStamp_of_20120618T151047_1000()
        {
            TestSerialization<Burn>(_xmlPath, x =>
            {
                Assert.AreEqual(new DateTime(2012, 6, 18, 15, 10, 47).AddHours(6), x.LastSync.TimeStamp);
            });
        }

        [Test]
        public void GIVEN_BodyMedia_Example_XML_WHEN_deserialized_THEN_the_result_should_have_a_LastSync_Type_of_UPLOAD_SYNC_MAC()
        {
            TestSerialization<Burn>(_xmlPath, x =>
            {
                Assert.AreEqual("UPLOAD_SYNC_MAC", x.LastSync.Type);
            });
        }

        [Test]
        public void GIVEN_BodyMedia_Example_XML_WHEN_deserialized_THEN_the_result_should_have_a_non_null_days_collection()
        {
            TestSerialization<Burn>(_xmlPath, x =>
            {
                Assert.IsNotNull(x.BurnDays);
            });
        }

        [Test]
        public void GIVEN_BodyMedia_Example_XML_WHEN_deserialized_THEN_the_result_should_have_a_days_collection_with_0_elements()
        {
            TestSerialization<Burn>(_xmlPath, x =>
            {
                Assert.AreEqual(0, x.BurnDays.Length);
            });
        }
    }
}

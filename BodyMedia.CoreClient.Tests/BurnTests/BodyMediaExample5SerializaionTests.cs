using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using BodyMedia.CoreClient.Entities;

namespace BodyMedia.CoreClient.Tests.BurnTests
{
    [TestFixture]
    public class BodyMediaExample5SerializaionTests : BaseSerializationTest
    {
        private const string _xmlPath = "BodyMedia.CoreClient.Tests.ExampleXml.Burn_Example5.xml";

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
        public void GIVEN_BodyMedia_Example_XML_WHEN_deserialized_THEN_the_result_should_have_a_LastSync_TimeStamp_of_20120621T151047_1000()
        {
            TestSerialization<Burn>(_xmlPath, x =>
            {
                Assert.AreEqual(new DateTime(2012, 6, 21, 15, 10, 47).AddHours(6), x.LastSync.TimeStamp);
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
        public void GIVEN_BodyMedia_Example_XML_WHEN_deserialized_THEN_the_result_should_have_a_days_collection_with_1_elements()
        {
            TestSerialization<Burn>(_xmlPath, x =>
            {
                Assert.AreEqual(1, x.BurnDays.Length);
            });
        }

        [Test]
        public void GIVEN_BodyMedia_Example_XML_WHEN_deserialized_THEN_the_result_should_have_a_days_element_with_17_minute_elements()
        {
            TestSerialization<Burn>(_xmlPath, x =>
            {
                Assert.AreEqual(17, x.BurnDays[0].Minutes.Length);
            });
        }

        [Test]
        public void GIVEN_BodyMedia_Example_XML_WHEN_deserialized_THEN_the_results_1st_days_1st_minute_should_have_an_ActivityType_of_MetsActivityType()
        {
            TestSerialization<Burn>(_xmlPath, x =>
            {
                Assert.AreEqual(MetsActivityType.ModerateActivity, x.BurnDays[0].Minutes[0].ActivityType);
            });
        }

        [Test]
        public void GIVEN_BodyMedia_Example_XML_WHEN_deserialized_THEN_the_results_1st_days_1st_minute_should_have_an_Source_of_ObtainedFromDevice()
        {
            TestSerialization<Burn>(_xmlPath, x =>
            {
                Assert.AreEqual(EnergySource.ObtainedFromDevice, x.BurnDays[0].Minutes[0].Source);
            });
        }


        [Test]
        public void GIVEN_BodyMedia_Example_XML_WHEN_deserialized_THEN_the_results_1st_days_1st_minute_should_have_an_Mets_of_4_64()
        {
            TestSerialization<Burn>(_xmlPath, x =>
            {
                Assert.AreEqual(4.64, x.BurnDays[0].Minutes[0].Mets);
            });
        }

        [Test]
        public void GIVEN_BodyMedia_Example_XML_WHEN_deserialized_THEN_the_results_1st_days_1st_minute_should_have_an_Calories_of_8_065()
        {
            TestSerialization<Burn>(_xmlPath, x =>
            {
                Assert.AreEqual(8.065, x.BurnDays[0].Minutes[0].Calories);
            });
        }

        [Test]
        public void GIVEN_BodyMedia_Example_XML_WHEN_deserialized_THEN_the_results_1st_days_last_minute_should_have_an_ActivityType_of_MetsActivityType()
        {
            TestSerialization<Burn>(_xmlPath, x =>
            {
                Assert.AreEqual(MetsActivityType.Sedentaryactivity, x.BurnDays[0].Minutes[16].ActivityType);
            });
        }

        [Test]
        public void GIVEN_BodyMedia_Example_XML_WHEN_deserialized_THEN_the_results_1st_days_last_minute_should_have_an_Source_of_ObtainedFromDevice()
        {
            TestSerialization<Burn>(_xmlPath, x =>
            {
                Assert.AreEqual(EnergySource.ObtainedFromDevice, x.BurnDays[0].Minutes[16].Source);
            });
        }


        [Test]
        public void GIVEN_BodyMedia_Example_XML_WHEN_deserialized_THEN_the_results_1st_days_last_minute_should_have_an_Mets_of_0_93()
        {
            TestSerialization<Burn>(_xmlPath, x =>
            {
                Assert.AreEqual(0.93, x.BurnDays[0].Minutes[16].Mets);
            });
        }

        [Test]
        public void GIVEN_BodyMedia_Example_XML_WHEN_deserialized_THEN_the_results_1st_days_last_minute_should_have_an_Calories_of_1_623()
        {
            TestSerialization<Burn>(_xmlPath, x =>
            {
                Assert.AreEqual(1.623, x.BurnDays[0].Minutes[16].Calories);
            });
        }
    }
}

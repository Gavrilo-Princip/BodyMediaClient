using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using BodyMedia.CoreClient.Entities;

namespace BodyMedia.CoreClient.Tests.ActivityTests
{
    [TestFixture]
    public class BodyMediaExample1SerializaionTests : BaseSerializationTest
    {
        private const string _xmlPath = "BodyMedia.CoreClient.Tests.ExampleXml.ActivityLog_Example1.xml";

        [Test]
        public void GIVEN_BodyMedia_Example_XML_WHEN_deserialized_THEN_there_should_not_be_an_exception()
        {
            TestSerialization<ActivityLog>(_xmlPath, x =>
            {
            });
        }

        [Test]
        public void GIVEN_BodyMedia_Example_XML_WHEN_deserialized_THEN_the_result_should_not_be_null()
        {
            TestSerialization<ActivityLog>(_xmlPath, x =>
            {
                Assert.IsNotNull(x);
            });
        }

        [Test]
        public void GIVEN_BodyMedia_Example_XML_WHEN_deserialized_THEN_the_result_should_have_a_start_date_of_20110618()
        {
            TestSerialization<ActivityLog>(_xmlPath, x =>
            {
                Assert.AreEqual(new DateTime(2011, 6, 18), x.StartDate);
            });
        }

        [Test]
        public void GIVEN_BodyMedia_Example_XML_WHEN_deserialized_THEN_the_result_should_have_an_end_date_of_20110618()
        {
            TestSerialization<ActivityLog>(_xmlPath, x =>
            {
                Assert.AreEqual(new DateTime(2011, 6, 18), x.EndDate);
            });
        }

        [Test]
        public void GIVEN_BodyMedia_Example_XML_WHEN_deserialized_THEN_the_result_should_not_have_a_null_ActivityDay_collection()
        {
            TestSerialization<ActivityLog>(_xmlPath, x =>
            {
                Assert.IsNotNull(x.ActivityDays);
            });
        }

        [Test]
        public void GIVEN_BodyMedia_Example_XML_WHEN_deserialized_THEN_the_result_should_have_1_ActivityDay()
        {
            TestSerialization<ActivityLog>(_xmlPath, x =>
            {
                Assert.AreEqual(1, x.ActivityDays.Length);
            });
        }

        [Test]
        public void GIVEN_BodyMedia_Example_XML_WHEN_deserialized_THEN_the_results_first_ActivityDay_should_have_Date_of_20110618()
        {
            TestSerialization<ActivityLog>(_xmlPath, x =>
            {
                Assert.AreEqual(new DateTime(2011, 6, 18), x.ActivityDays[0].Date);
            });
        }

        [Test]
        public void GIVEN_BodyMedia_Example_XML_WHEN_deserialized_THEN_the_results_first_ActivityDay_should_4_activities()
        {
            TestSerialization<ActivityLog>(_xmlPath, x =>
            {
                Assert.AreEqual(4, x.ActivityDays[0].Activities.Length);
            });
        }

        [Test]
        public void GIVEN_BodyMedia_Example_XML_WHEN_deserialized_THEN_the_results_first_ActivityDays_first_activity_should_have_calories_of_242()
        {
            TestSerialization<ActivityLog>(_xmlPath, x =>
            {
                Assert.AreEqual(242, x.ActivityDays[0].Activities[0].Calories);
            });
        }

        [Test]
        public void GIVEN_BodyMedia_Example_XML_WHEN_deserialized_THEN_the_results_first_ActivityDays_first_activity_should_have_type_of_CALISTHENICS_VIGOROUS()
        {
            TestSerialization<ActivityLog>(_xmlPath, x =>
            {
                Assert.AreEqual("CALISTHENICS_VIGOROUS", x.ActivityDays[0].Activities[0].Type);
            });
        }

        [Test]
        public void GIVEN_BodyMedia_Example_XML_WHEN_deserialized_THEN_the_results_first_ActivityDays_first_activity_should_have_start_of_20110618T130800_0400()
        {
            TestSerialization<ActivityLog>(_xmlPath, x =>
            {
                Assert.AreEqual(new DateTime(2011, 6, 18, 13, 8, 0), x.ActivityDays[0].Activities[0].StartDate);
            });
        }

        [Test]
        public void GIVEN_BodyMedia_Example_XML_WHEN_deserialized_THEN_the_results_first_ActivityDays_first_activity_should_have_end_of_20110618T132800_0400()
        {
            TestSerialization<ActivityLog>(_xmlPath, x =>
            {
                Assert.AreEqual(new DateTime(2011, 6, 18, 13, 28, 0), x.ActivityDays[0].Activities[0].EndDate);
            });
        }
    }
}

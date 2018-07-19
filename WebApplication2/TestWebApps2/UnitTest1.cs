using System;
using System.Collections;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebApplication2.Models;
using WebApplication2.Services;
using System.Linq;

namespace TestWebApps2
{
    public class CardData4Test
    {
        public string TestScenario { get; set; }
        public string ExpectedResult { get; set; }
        public string Name { get; set; }
        public string CardNo { get; set; }
        public string ExpDate { get; set; }

        public static CardData4Test Create(string testcase, string res, string cName, string cNumber, string cExpDate)
        {
            return new CardData4Test
            {
                TestScenario = testcase,
                ExpectedResult = res,
                Name = cName,
                CardNo = cNumber,
                ExpDate = cExpDate
            };
        }
    }
    public class CardData4Test_key
    {
        public string TestScenario { get; set; }
        public string CardNo { get; set; }

        public static CardData4Test_key CreateKey(string testcase, string cNumber)
        {
            return new CardData4Test_key
            {
                TestScenario = testcase,
                CardNo = cNumber
            };
        }
    }
    public class ScenarioTest
    {
        public static string ValidVISA = "ValidVISA";
        public static string ValidVISAExpiry = "ValidVISAExpiry";
        public static string ValidMASTER = "ValidMASTER";
        public static string ValidMASTERExpiry = "ValidMASTERExpiry";
        public static string ValidJCB = "ValidMASTER";
        public static string ValidJCBExpiry = "ValidMASTERExpiry";
        public static string ValidAMEX = "ValidAMEX";
        public static string ValidAMEXExpiry = "ValidAMEXExpiry";

        public static string InvalidVISA = "InvalidVISA";
        public static string InvalidMASTER = "InvalidMASTER";
        public static string InvalidJCB = "InvalidJCB";
        public static string InvalidAMEX = "InvalidAMEX";
        public static string InvalidUnknown = "InvalidUnknown";

        public static string DoesNotExists = "DoesNotExists";
    }

    [TestClass]
    public class UnitTest1
    {
        private static Dictionary<CardData4Test_key, CardData4Test> TestData;
        private ArrayList KeyTestData;

        public UnitTest1()
        {
            TestData = new Dictionary<CardData4Test_key, CardData4Test>();
            KeyTestData = new ArrayList();
            CardData4Test_key Key;
            CardData4Test card;

            //DATA SET For Test
            card = CardData4Test.Create(ScenarioTest.ValidVISA, ValidateCardType.VISA, "Name LastName", "4567890123456789", "012020");
            Key = CardData4Test_key.CreateKey(card.TestScenario, card.CardNo);
            TestData.Add(Key, card);
            KeyTestData.Add(Key);
            card = CardData4Test.Create(ScenarioTest.ValidVISA, ValidateCardType.VISA, "Name LastName", "4567890123456790", "012021");
            Key = CardData4Test_key.CreateKey(card.TestScenario, card.CardNo);
            TestData.Add(Key, card);
            KeyTestData.Add(Key);
            card = CardData4Test.Create(ScenarioTest.ValidVISA, ValidateCardType.VISA, "Name LastName", "4567890123456791", "012022");
            Key = CardData4Test_key.CreateKey(card.TestScenario, card.CardNo);
            TestData.Add(Key, card);
            KeyTestData.Add(Key);
            card = CardData4Test.Create(ScenarioTest.ValidVISA, ValidateCardType.VISA, "Name LastName", "4567890123456792", "012023");
            Key = CardData4Test_key.CreateKey(card.TestScenario, card.CardNo);
            TestData.Add(Key, card);
            KeyTestData.Add(Key);

            card = CardData4Test.Create(ScenarioTest.ValidMASTER, ValidateCardType.MASTER, "Name LastName", "5678901234567890", "012021");
            Key = CardData4Test_key.CreateKey(card.TestScenario, card.CardNo);
            TestData.Add(Key, card);
            KeyTestData.Add(Key);
            card = CardData4Test.Create(ScenarioTest.ValidMASTER, ValidateCardType.MASTER, "Name LastName", "5678901234567891", "012023");
            Key = CardData4Test_key.CreateKey(card.TestScenario, card.CardNo);
            TestData.Add(Key, card);
            KeyTestData.Add(Key);
            card = CardData4Test.Create(ScenarioTest.ValidMASTER, ValidateCardType.MASTER, "Name LastName", "5678901234567892", "012017");
            Key = CardData4Test_key.CreateKey(card.TestScenario, card.CardNo);
            TestData.Add(Key, card);
            KeyTestData.Add(Key);
            card = CardData4Test.Create(ScenarioTest.ValidMASTER, ValidateCardType.MASTER, "Name LastName", "5678901234567893", "012020");
            Key = CardData4Test_key.CreateKey(card.TestScenario, card.CardNo);
            TestData.Add(Key, card);
            KeyTestData.Add(Key);

            card = CardData4Test.Create(ScenarioTest.ValidJCB, ValidateCardType.JCB, "Name LastName", "3456789012345678", "012099");
            Key = CardData4Test_key.CreateKey(card.TestScenario, card.CardNo);
            TestData.Add(Key, card);
            KeyTestData.Add(Key);
            card = CardData4Test.Create(ScenarioTest.ValidJCB, ValidateCardType.JCB, "Name LastName", "3456789012345679", "022099");
            Key = CardData4Test_key.CreateKey(card.TestScenario, card.CardNo);
            TestData.Add(Key, card);
            KeyTestData.Add(Key);
            card = CardData4Test.Create(ScenarioTest.ValidJCB, ValidateCardType.JCB, "Name LastName", "3456789012345680", "032099");
            Key = CardData4Test_key.CreateKey(card.TestScenario, card.CardNo);
            TestData.Add(Key, card);
            KeyTestData.Add(Key);
            card = CardData4Test.Create(ScenarioTest.ValidJCB, ValidateCardType.JCB, "Name LastName", "3456789012345681", "042099");
            Key = CardData4Test_key.CreateKey(card.TestScenario, card.CardNo);
            TestData.Add(Key, card);
            KeyTestData.Add(Key);

            card = CardData4Test.Create(ScenarioTest.ValidAMEX, ValidateCardType.AMEX, "Name LastName", "345678901234567", "012099");
            Key = CardData4Test_key.CreateKey(card.TestScenario, card.CardNo);
            TestData.Add(Key, card);
            KeyTestData.Add(Key);
            card = CardData4Test.Create(ScenarioTest.ValidAMEX, ValidateCardType.AMEX, "Name LastName", "345678901234568", "012099");
            Key = CardData4Test_key.CreateKey(card.TestScenario, card.CardNo);
            TestData.Add(Key, card);
            KeyTestData.Add(Key);
            card = CardData4Test.Create(ScenarioTest.ValidAMEX, ValidateCardType.AMEX, "Name LastName", "345678901234569", "012099");
            Key = CardData4Test_key.CreateKey(card.TestScenario, card.CardNo);
            TestData.Add(Key, card);
            KeyTestData.Add(Key);
            card = CardData4Test.Create(ScenarioTest.ValidAMEX, ValidateCardType.AMEX, "Name LastName", "345678901234570", "012099");
            Key = CardData4Test_key.CreateKey(card.TestScenario, card.CardNo);
            TestData.Add(Key, card);
            KeyTestData.Add(Key);

            card = CardData4Test.Create(ScenarioTest.InvalidUnknown, ValidateCardType.Unknown, "Name LastName", "6678901234567889", "012019");
            Key = CardData4Test_key.CreateKey(card.TestScenario, card.CardNo);
            TestData.Add(Key, card);
            KeyTestData.Add(Key);

            card = CardData4Test.Create(ScenarioTest.DoesNotExists, ValidateStatus.DoesNotExists, "Name LastName", "5578901234567889", "012019");
            Key = CardData4Test_key.CreateKey(card.TestScenario, card.CardNo);
            TestData.Add(Key, card);
            KeyTestData.Add(Key);
        }
        [TestMethod, TestCategory("GET Data by CardNo")]
        public void TestGetData()
        {
            var ExpectedResult = new CardInfo { CardNumber = "4567890123456789" };            
            CardServices _Repo = new CardServices();
            var Test = _Repo.GetCardbyNumber("4567890123456789");

            Assert.AreEqual(ExpectedResult.CardNumber, Test.CardNumber);
        }

        [TestMethod, TestCategory("Card Validation")]
        public void TestVerifyVISA()
        {
            var ExpectedResult = new ValidateResult();            
            CardServices _Repo = new CardServices();

            IEnumerator enumerator = KeyTestData.GetEnumerator();
            while (enumerator.MoveNext())
            {
                object obj = enumerator.Current;
                CardData4Test_key keydef = new CardData4Test_key();
                CardData4Test_key key = (obj != null) ? ((CardData4Test_key)obj) : keydef;

                if (key.TestScenario == ScenarioTest.ValidVISA)
                {
                    CardData4Test card = TestData[key];
                    ExpectedResult = new ValidateResult { CardType = card.ExpectedResult };
                    CardInfo cardtest = CardInfo.Create(card.Name, card.CardNo, card.ExpDate);
                    var Test = _Repo.ValidateCardInfo(cardtest);

                    Assert.AreEqual(ExpectedResult.CardType, Test.CardType);
                }
            }
        }

        [TestMethod, TestCategory("Card Validation")]
        public void TestVerifyMASTER()
        {
            var ExpectedResult = new ValidateResult();            
            CardServices _Repo = new CardServices();

            IEnumerator enumerator = KeyTestData.GetEnumerator();
            while (enumerator.MoveNext())
            {
                object obj = enumerator.Current;
                CardData4Test_key keydef = new CardData4Test_key();
                CardData4Test_key key = (obj != null) ? ((CardData4Test_key)obj) : keydef;

                if (key.TestScenario == ScenarioTest.ValidMASTER)
                {
                    CardData4Test card = TestData[key];
                    ExpectedResult = new ValidateResult { CardType = card.ExpectedResult };
                    CardInfo cardtest = CardInfo.Create(card.Name, card.CardNo, card.ExpDate);
                    var Test = _Repo.ValidateCardInfo(cardtest);

                    Assert.AreEqual(ExpectedResult.CardType, Test.CardType);
                }
            }
        }

        [TestMethod, TestCategory("Card Validation")]
        public void TestVerifyJCB()
        {
            var ExpectedResult = new ValidateResult();            
            CardServices _Repo = new CardServices();

            IEnumerator enumerator = KeyTestData.GetEnumerator();
            while (enumerator.MoveNext())
            {
                object obj = enumerator.Current;
                CardData4Test_key keydef = new CardData4Test_key();
                CardData4Test_key key = (obj != null) ? ((CardData4Test_key)obj) : keydef;

                if (key.TestScenario == ScenarioTest.ValidJCB)
                {
                    CardData4Test card = TestData[key];
                    ExpectedResult = new ValidateResult { CardType = card.ExpectedResult };
                    CardInfo cardtest = CardInfo.Create(card.Name, card.CardNo, card.ExpDate);
                    var Test = _Repo.ValidateCardInfo(cardtest);

                    Assert.AreEqual(ExpectedResult.CardType, Test.CardType);
                }
            }
        }

        [TestMethod, TestCategory("Card Validation")]
        public void TestVerifyAMEX()
        {
            var ExpectedResult = new ValidateResult();            
            CardServices _Repo = new CardServices();

            IEnumerator enumerator = KeyTestData.GetEnumerator();
            while (enumerator.MoveNext())
            {
                object obj = enumerator.Current;
                CardData4Test_key keydef = new CardData4Test_key();
                CardData4Test_key key = (obj != null) ? ((CardData4Test_key)obj) : keydef;

                if (key.TestScenario == ScenarioTest.ValidAMEX)
                {
                    CardData4Test card = TestData[key];
                    ExpectedResult = new ValidateResult { CardType = card.ExpectedResult };
                    CardInfo cardtest = CardInfo.Create(card.Name, card.CardNo, card.ExpDate);
                    var Test = _Repo.ValidateCardInfo(cardtest);

                    Assert.AreEqual(ExpectedResult.CardType, Test.CardType);
                }
            }
        }

        [TestMethod, TestCategory("Card Validation")]
        public void TestVerifyUnkown()
        {
            var ExpectedResult = new ValidateResult();            
            CardServices _Repo = new CardServices();

            IEnumerator enumerator = KeyTestData.GetEnumerator();
            while (enumerator.MoveNext())
            {
                object obj = enumerator.Current;
                CardData4Test_key keydef = new CardData4Test_key();
                CardData4Test_key key = (obj != null) ? ((CardData4Test_key)obj) : keydef;

                if (key.TestScenario == ScenarioTest.InvalidUnknown)
                {
                    CardData4Test card = TestData[key];
                    ExpectedResult = new ValidateResult { CardType = card.ExpectedResult };
                    CardInfo cardtest = CardInfo.Create(card.Name, card.CardNo, card.ExpDate);
                    var Test = _Repo.ValidateCardInfo(cardtest);

                    Assert.AreEqual(ExpectedResult.CardType, Test.CardType);
                }
            }
        }

        [TestMethod, TestCategory("Card Validation")]
        public void TestVerifyNotExists()
        {
            var ExpectedResult = new ValidateResult();            
            CardServices _Repo = new CardServices();

            IEnumerator enumerator = KeyTestData.GetEnumerator();
            while (enumerator.MoveNext())
            {
                object obj = enumerator.Current;
                CardData4Test_key keydef = new CardData4Test_key();
                CardData4Test_key key = (obj != null) ? ((CardData4Test_key)obj) : keydef;

                if (key.TestScenario == ScenarioTest.DoesNotExists)
                {
                    CardData4Test card = TestData[key];
                    ExpectedResult = new ValidateResult { Result = card.ExpectedResult };
                    CardInfo cardtest = CardInfo.Create(card.Name, card.CardNo, card.ExpDate);
                    var Test = _Repo.ValidateCardInfo(cardtest);

                    Assert.AreEqual(ExpectedResult.Result, Test.Result);
                }
            }
        }
    }
}

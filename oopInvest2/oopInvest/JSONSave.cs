using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization.Json;
using System.Runtime.Serialization;
using System.IO;

namespace oopInvest
{
    class JSONSave
    {
        DataContractJsonSerializer JSONInvestment = new DataContractJsonSerializer(typeof(Investment));

        public Investment SaveJSON(Investment investment)
        {
            using (FileStream fs = new FileStream("investment.json", FileMode.OpenOrCreate))
            {
                JSONInvestment.WriteObject(fs, investment);
            }
            return investment;
        }
        public Investment LoadJSON(Investment investment)
        {
            using (FileStream fs = new FileStream("investment.json", FileMode.OpenOrCreate))
            {
                Investment _investment = (Investment)JSONInvestment.ReadObject(fs);
                investment = _investment;
                return investment;
            }
        }
    }
}

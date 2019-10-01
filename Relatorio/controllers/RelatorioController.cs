using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using Relatorio.serializations;
using Relatorio.services;

namespace Relatorio.controllers
{
    class RelatorioController
    {
        DataJsonService jsonService = new DataJsonService();
        public List<Data> listJson()
        {
            var json = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + @"\..\..\..\serializations\" + jsonService.pathJson());

            var js = new DataContractJsonSerializer(typeof(List<Data>));
            var ms = new MemoryStream(Encoding.UTF8.GetBytes(json));
            var dataJson = (List<Data>)js.ReadObject(ms);



            return dataJson;
        }

        public List<Data> agrouping(List<Data> data)
        {
            var groupedByMonth = data.GroupBy(t => t.DATAUSO);

            var groupedByUser = data.GroupBy(t => t.CODIGOUSUARIO);

            var groupedByCompany = data.GroupBy(t => t.CODIGOEMPRESA);

            var groupedByActivity = data.GroupBy(t => t.CODIGOATIVIDADE);

            foreach (var jsons in groupedByMonth)
            {
                Console.WriteLine(jsons);
            }
            return data;

        }

    }
}

    
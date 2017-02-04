using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library;

namespace StockQuery {
    public class Stock {
        private static string queryUrl = "http://download.finance.yahoo.com/d/quotes.csv?s=@&f=$";
        private static string result = String.Empty;
        private static List<string> queryList = new List<string>();

        public Stock(string[] tickers, string query) {
            string url = queryUrl.Replace("@", ConvertStringArrayToStringJoin(tickers)).Replace("$", NormalizeQuery(query));

            result = WebQuery.GetResult(url);
        }

        private static string NormalizeQuery(string query) {
            string[] queries = query.Split('|');
            string result = string.Empty;

            for (int i = 0; i < queries.Length; i++) {
                foreach (YahooQueryItem yahooQuery in YahooQueries.yahooQueries) {
                    if (queries[i] == yahooQuery.Name) {
                        result = result + yahooQuery.Name;

                        queryList.Add(yahooQuery.Description);
                    }
                }
            }

            return result;
        }

        private static string ConvertStringArrayToStringJoin(string[] array) {
            return string.Join("+", array).Trim();
        }

        public void GetInformation() {
            string[] resultLines = result.Split(
                new char[] { '\r', '\n' },
                StringSplitOptions.RemoveEmptyEntries
            );
            string[] tableHeaders = queryList.Select(i => i.ToString()).ToArray();
            var table = new Table(tableHeaders);

            for (int i = 0; i < resultLines.Length; i++) {
                string[] resultLine = resultLines[i].Split(',');
                List<string> rowData = new List<string>();

                for (int j = 0; j < resultLine.Length; j++) {
                    rowData.Add(resultLine[j]);
                }

                string[] row = rowData.ToArray();

                table.AddRow(row);
            }
            
            table.Print();
        }
    }
}

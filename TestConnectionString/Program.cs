using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConnectionString {
	class Program {
		static void Main(string[] args) {
			var connStr = @"<connection string goes here>";
			System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection(connStr);
			conn.Open();
			if(conn.State != System.Data.ConnectionState.Open) {
				Console.WriteLine("Connection did not open!");
			} else {
				Console.WriteLine("Connection open successful!");
			}
			Console.WriteLine("press any key to end ...");
			Console.ReadKey();
		}
	}
}

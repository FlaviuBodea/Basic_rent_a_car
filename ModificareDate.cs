using System;
using MySql.Data.MySqlClient;


public class Class1
{
	public Class1()
	{
		static MySqlConnection conn = new MySqlConnection("DataSource=localhost; UserID=root; database = rent_a_car");

		MySqlDataAdapter adapt;
		DataTable filmeleDT = new DataTable();
		MySqlCommandBuilder cb;

	}
}

CREATE DATABASE College; GO
USE College; GO

CREATE TABLE Student (
Id I T,
 ame VARCHAR(50),
Department VARCHAR(50)
); GO
I SERT I TO Student VALUES (1, 'Abdul', 'IT'),
(2, 'Chandru', 'CSE'),
(3, 'Reshma', 'ECE'); GO

SELECT * FROM Student; GO

PROGRAM
using System; using System.Data;
using System.Data.SqlClient;


class Program
{
static void Main()
{
string con = @"Data Source=.\SQLEXPRESS; Initial Catalog=College;
Integrated Security=True; TrustServerCertificate=True";
 
SqlDataAdapter da = new SqlDataAdapter( "SELECT * FROM Student", con);

DataSet ds = new DataSet();


da.Fill(ds, "Student");


foreach (DataRow row in ds.Tables["Student"].Rows)
{
Console.WriteLine(row["Id"] + " " + row["Name"]);
}
}
}


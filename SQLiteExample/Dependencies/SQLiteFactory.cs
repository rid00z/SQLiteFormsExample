using System;
using SQLite.Net;

namespace SQLiteExample
{
	public interface ISQLiteFactory
	{
		SQLiteConnection GetConnection(string fileName);
	}
}


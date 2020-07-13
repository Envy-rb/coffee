using kolyaKurs.entity;
using kolyaKurs.Parse;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;

namespace kolyaKurs.Service
{
    class IngredientsService
    {
        public string ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Resources\DataBases\IngredientDB\IngredientDB.mdb";
        public BindingList<IngredientInterface> Ingredients = new BindingList<IngredientInterface>();
        public IngredientsService()
        {
            parseDB();
        }

        public void My_Execute_Non_Query(string CommandText)
        {
            OleDbConnection conn = new OleDbConnection(ConnectionString);
            conn.Open();
            OleDbCommand myCommand = conn.CreateCommand();
            myCommand.CommandText = CommandText;
            myCommand.ExecuteNonQuery();
            conn.Close();
        }

        public void addIngredient(IngredientInterface ingredient)
        {
            string query = string.Format("INSERT INTO Ingredient (Name, Price, Type) VALUES ('{0}','{1}','{2}')", ingredient.Name, ingredient.Price.ToString(), ingredient.IngredientType);
            Ingredients.Add(ingredient);
            My_Execute_Non_Query(query);
        }

        public void removeIngredient(int index) => Ingredients.RemoveAt(index);

        public void removeIngredient(IngredientInterface item)
        {
            Ingredients.Remove(item);
            string query = string.Format("DELETE * from Ingredient where Name = '{0}'", item.Name);
            My_Execute_Non_Query(query);
        }

        private void parseDB()
        {
            string query = "SELECT [Ingredient.Name], [Ingredient.Price], [Ingredient.Type] FROM Ingredient";
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(query, ConnectionString);
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds, "Ingredient");
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                Ingredients.Add(IngredientParser.parseIngredient(row[0].ToString(), row[1].ToString(), row[2].ToString()));
            }
        }
    }
}

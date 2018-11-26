using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConexionDB;

namespace ConexionDB
{
    public class Tabla
    {

        public Tabla()
        {
            Tabla.State = FlagState.CREACION;
        
        }
        public static FlagState State;
        public string Error;
        public string Table_name;
        public int Table_id;
        public string Table_comment;
        public List<Columna> columnas = new List<Columna>();
        public class Columna
        {
            public Columna(String Name, TipoDeCampo Type, int ColLenght, bool IsNullable, object Default, Indices Keys, string Comment,object _value)
            {
                this.Column_name = Name; this.Column_Type = Type; this.Column_lenght = ColLenght; this.Column_Is_Nullable = IsNullable;
                this.Column_Default = Default; this.Culumn_keys = Keys; this.Column_comment = Comment;
                this.Value = _value;

            }
            public String Column_name;
            public TipoDeCampo Column_Type;
            public int Column_lenght;
            public bool Column_Is_Nullable;
            public object Column_Default;
            public Indices Culumn_keys;
            public String Column_comment;
            public object Value;
            
            

        }

        public string CreateTable()
        {

            int con = 0;
            string Sentecia = "";
            bool res = false;
            try
            {

                Sentecia = "DROP TABLE IF EXISTS "+this.Table_name+ "; CREATE TABLE ";
                Sentecia += this.Table_name;
                Sentecia += " ( id int(16) unsigned NOT NULL  PRIMARY KEY auto_increment, ";
                
                foreach (Columna col in this.columnas)
                {
                    
                    string _comment = "";
                    string _defaul = "";
                    string _long = "";
                    string _notNull = "";
                    if (col.Column_lenght != 0)
                    {
                        _long = "("+col.Column_lenght+")";
                    }
                    if (!(col.Column_Default is null))
                    {
                        if (col.Column_Type == TipoDeCampo.Char || col.Column_Type == TipoDeCampo.Varchar || col.Column_Type == TipoDeCampo.Text)
                        {
                            _defaul = "DEFAULT '" + col.Column_Default+"'";
                        }
                        else
                        {
                            _defaul = "DEFAULT " + col.Column_Default;
                        }
                        
                    }
                    if (col.Column_comment.Length > 0)
                    {
                        _comment = "COMMENT '"+col.Column_comment+"'";
                    }
                    if (!col.Column_Is_Nullable)
                    {
                        _notNull = " NOT NULL ";
                    }
                    else
                    {
                        _notNull = " NULL ";
                    }
                    
                    Sentecia += " "+col.Column_name + " " + col.Column_Type + _long + " " + _notNull + " "+_defaul + " "+ _comment;
                    con++;
                    if (con < columnas.Count)
                    {
                        Sentecia += ",";
                    }     
                }
                Sentecia += " );";
            }
            catch (Exception ex)
            {
                Error = ex.StackTrace.ToString();
                Tabla.State = FlagState.ERROR_SYNTAXIS;
            }
            return Sentecia;
        }
        public bool CreaTabla2() {
            return ExecuteQuery.CreaTablaMysql(CreateTable());
        }
        public string InsertInto()
        {
            int con = 0;
            string Sentecia = "";
            
            try
            {

                Sentecia = "INSERT INTO " + this.Table_name +" (";
                
                foreach (Columna col in this.columnas)
                {
                    
                    Sentecia += " " + col.Column_name;
                    con++;
                    if (con < columnas.Count)
                    {
                        Sentecia += ",";
                    }
                }
                
                
                Sentecia += " ) VALUES ('"+columnas[0].Value+"','"+columnas[1].Value+"','"+columnas[2].Value+"','"+columnas[3].Value+"','"+columnas[4].Value+"');";
            }
            catch (Exception ex)
            {
                Error = ex.StackTrace.ToString();
                Tabla.State = FlagState.ERROR_SYNTAXIS;
            }
            return Sentecia;
        }
        public bool Insert(){
            return ExecuteQuery.InsertIntoMysql(InsertInto());
        }
       
    }
    public enum FlagState
    {
        CREACION, CREADA, ALTERADA, BORRADA, ERROR_SYNTAXIS, INSERTADO
    }
    public enum TipoDeCampo
    {
        TinyInt, Int, BigInt, Float, Double, Varchar, Char, Text, Date, Time, DateTime, Boolean
    }
    public enum Indices
    {
         Key, Unique, Mul, NULL
    }
    public class Clientes : Tabla {
        
        public Clientes(string[]columna,string[]row, string tabla)
        {
            this.Table_name = tabla;
            this.Table_comment = "En esta Se guardara la informacion de los clientes";
            this.columnas.Add(new Columna(columna[0], TipoDeCampo.Varchar, 20, false, null, Indices.NULL, "Name of Clients",null));
            this.columnas.Add(new Columna("apellido_cliente",TipoDeCampo.Varchar, 50, false, null, Indices.NULL, "Apellidos del clientes", null));
            this.columnas.Add(new Columna("telefono_cliente", TipoDeCampo.Varchar, 10, false, null, Indices.NULL, "Telefono del clientes", null));
            this.columnas.Add(new Columna("Correo_cliente", TipoDeCampo.Varchar, 30, true, "No definido", Indices.NULL, "Email de clientes", null));
            this.columnas.Add(new Columna("rfc_cliente", TipoDeCampo.Varchar, 13, false, null, Indices.NULL, "RFC of clients",null));
        }
        public void CreaCampo(String Name, TipoDeCampo Type, int ColLenght, bool IsNullable, object Default, Indices Keys, string Comment) {
            this.columnas.Add(new Columna(Name, Type, ColLenght, IsNullable, Default, Keys, Comment,null));

        }
        
        public string Name {
            set { this.columnas[0].Value = value; }
            get { return this.columnas[0].Value.ToString();  }
        }
        public string Apellidos {
            set { this.columnas[1].Value = value; }
            get { return this.columnas[1].Value.ToString(); }
        }
        public string Telefono
        {
            set
            {
                //if (value.Length == 10)
                //{
                    this.columnas[2].Value = value;
                //}
                //else
                //{
                //    this.columnas[2].Value = "Formato incorrecto";
                //}
            }
            get { return this.columnas[2].Value.ToString(); }
        }
        public string Correo
        {
            set { this.columnas[3].Value = value; }
            get { return this.columnas[3].Value.ToString(); }
        }
        public string Rfc {
            set { this.columnas[4].Value = value; }
            get { return this.columnas[4].Value.ToString(); }
        }

    }
    
    
    //public class Ventas{
    //    public Clientes Cliente = new Clientes();
    //    public void DatosCliente()
    //    {
    //        Cliente.Name = "Alexis";
    //        Cliente.Apellidos = "Juhan Dragen";
    //        Cliente.Telefono = "666 666 666";
    //        Cliente.Correo = "SrOscuridad@gmail.evil";
    //        Cliente.Rfc = "ALEXIS007";
    //        string format = Cliente.Telefono + " Incorreto";
    //    }
    //}

}

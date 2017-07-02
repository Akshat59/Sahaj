using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Collections;
using m1.Shared;

namespace m1.Shared
{
    #region Constructor
    public class DatabaseManagement
    {
    }
    #endregion

    #region GeneralConstants
    public enum DataHelperType
    {
        AnsiString = System.Data.DbType.AnsiString,
        Int32 = System.Data.DbType.Int32,
        String = System.Data.DbType.String,
    }

    public enum DbTypeEE
    {
        AnsiString = 0,
        Int32 = 11,
        String = 16,
    }

    public enum ParameterDirectionN
    {
        Input = 1,
        Output = 2,
        InputOutput = 3,
        ReturnValue = 6
    }

    #endregion

    #region ParameterConstants

    #endregion


    #region GeneralClasses

    public abstract class BaseDac
    {

    }

    public class Parameter:IDataParameter
    {

        public Parameter()
        {
            this._dhType = DataHelperType.AnsiString;
            this._dbType = DbType.AnsiString;
            this._parameterName = "";
            this._parameterDirection = ParameterDirection.Input;
            this._value = null;

        }

        #region Properties
        private ParameterDirection _parameterDirection;

        public System.Data.ParameterDirection Direction
        {
            get { return _parameterDirection; }
            set { _parameterDirection = value; }
        }
        private DataHelperType _dhType;

        public DataHelperType DhType
        {
            get { return _dhType; }
            set { _dhType = value; }
        }
        private System.Data.DbType _dbType;

        public DbType DbType
        {
            get { return _dbType; }
            set { _dbType = value; }
        }
        private object _value;

        public object Value
        {
            get { return _value; }
            set { _value = value; }
        }
        private bool _isNullable;

        public bool IsNullable
        {
            get { return _isNullable; }
            set { _isNullable = value; }
        }
        private DataRowVersion _sourceVersion;

        public DataRowVersion SourceVersion
        {
            get { return _sourceVersion; }
            set { _sourceVersion = value; }
        }
        private string _parameterName;

        public string ParameterName 
        {
            get { return this._parameterName; }
            set { this._parameterName = value; }
        }
        private string _sourceColumn;

        public string SourceColumn
        {
            get { return _sourceColumn; }
            set { _sourceColumn = value; }
        }
        private int _size;

        public int Size
        {
            get { return _size; }
            set { _size = value; }
        }
        #endregion

    }


    #endregion


    #region Collections

    public class ParameterCollection : ArrayList
    {
        public ParameterCollection()
        {
            
        }

        
        public void Add(string paramName, object value)
        {
            if (value == null) { value = DBNull.Value; }
            Parameter p = new Parameter();
            p.ParameterName = paramName;
            p.Value = value;
            Add(p);        
        }

        public void Add(string paramName, DataHelperType dhType, object val) 
        {
            Add(paramName, ParameterDirection.Input, dhType, val);
        
        }

        public void Add(string paramName, DbType dbType, object val)
        {
            Add(paramName,ParameterDirection.Input,(DataHelperType)dbType,val);
        }

        public void Add(string paramName, ParameterDirection parameterDirection, DataHelperType dhType, object val)
        {        
            if(val == null) {val = DBNull.Value;}
            Add(paramName, parameterDirection, dhType, val.ToString().Length, val);
        }

        public void Add(string paramName, ParameterDirection parameterDirection, DataHelperType dhType, int size, object val)
        {
            Parameter p = new Parameter();

            p.ParameterName = paramName;
            p.Direction = parameterDirection;
            p.DhType = dhType;
            p.Size = size;
            p.Value = val;
            this.Add(p);
        }
    }
    #endregion
}


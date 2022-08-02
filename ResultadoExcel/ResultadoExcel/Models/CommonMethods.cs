﻿using System.ComponentModel;
using System.Data;

namespace ResultadoExcel.Models
{
    public static class CommonMethods
    {
        public static DataTable ConvertListToDataTable<T>(this IList<T> data)
        {
            PropertyDescriptorCollection props =
                TypeDescriptor.GetProperties(typeof(T));
            DataTable table = new DataTable();
            for (int i = 0; i < props.Count; i++)
            {
                PropertyDescriptor prop = props[i];
                if(prop.Name == "Fecha_Creacion" || prop.Name == "Estado")
                {
                    table.Columns.Add(prop.Name);
                }
                else
                {
                    table.Columns.Add(prop.Name, prop.PropertyType);
                }   
            }
            object[] values = new object[props.Count];
            foreach (T item in data)
            {
                for (int i = 0; i < values.Length; i++)
                {
                    values[i] = props[i].GetValue(item);
                }
                table.Rows.Add(values);
            }
            return table;
        }
    }
}
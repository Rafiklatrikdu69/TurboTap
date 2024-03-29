﻿using Google.Protobuf.Collections;
using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace WebApplication1.Models
{

    /// <author>
    /// Rafik BOUCHENNA
    /// </author>
    public abstract class DAO
    {
        // Fonctions synchrones avec les mêmes noms
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="args"></param>
        /// <returns></returns>
        public MySqlCommand _requete(string sql, Dictionary<string, object> args = null)
        {
            Singleton singleton = Singleton.Instance;

            
                using (MySqlCommand command = new MySqlCommand(sql, singleton.getBdd()))
                {
                    if (args != null)
                    {
                        foreach (var arg in args)
                        {
                            command.Parameters.AddWithValue(arg.Key, arg.Value);
                        }
                    }

                    command.ExecuteNonQuery();
                return command;
                }
            
            
        }

        public DataTable getLigne(string sql, Dictionary<string, object> args = null)
        {
            var statement = this._requete(sql, args);
            DataTable dt = new DataTable();

            using (MySqlDataReader reader = statement.ExecuteReader())
            {
                dt.Load(reader);
                reader.Close();
            }

            return dt;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="args"></param>
        /// <returns></returns>
        public DataTable getLignes(string sql, Dictionary<string, object> args = null)
        {
            Singleton singleton = Singleton.Instance;
            var statement = this._requete(sql, args);
            DataTable dt = new DataTable();

            using (MySqlDataReader reader = statement.ExecuteReader())
            {
                dt.Load(reader);
                reader.Close();
            }

            return dt;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="args"></param>
        public void Insert(string sql, Dictionary<string, object> args = null)
        {
            this._requete(sql, args);
        }
    }
}

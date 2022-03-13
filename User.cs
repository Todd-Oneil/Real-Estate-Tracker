using System;
using System.Collections.Generic;
using System.Text;
using System.Security.Cryptography;

namespace RealEstate
{
    class User
    {
        private string username;
        private int ID;
        private string password;

        public User(string username, string password)
        {
            this.username = username;
            this.password = password;
        }

        public User()
        {
            username = "";
            password = "";
        }

        public string GetUsername
        {
            get => username;
        }

        public string SetUsername
        {
            set => username = value;
        }

        public string GetPassword
        {
            get => password;
        }

        public string SetPassword
        {
            set => password = value;
        }

        public int GetID
        {
            get => ID;
        }
            
        public int SetID
        {
            set => ID = value;
        }

        public static string ComputeHash(string toHash)
        {
            /*
             * 1. Creates an encryption object
             * 2. Create a byte array and populate it with the hashed value of the passed in parameter
             * 3. create a string builder object
             * 4. Loop through the byte array and create a string of those bytes
             * 5. Return the string
             */
            using (SHA256 sha256Hash = SHA256.Create())// 1
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(toHash));// 2

                StringBuilder builder = new StringBuilder();// 3
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));// 4
                }
                return builder.ToString();// 5
            }
        }
    }
}

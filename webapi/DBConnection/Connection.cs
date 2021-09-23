using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using webapi.Models;

namespace webapi.DBConnection
{
    public class Connection
    {
        private MySqlConnection connection;

        public Connection()
        {
            Initialize();
        }

        public void Initialize()
        {
            string connectionString;
            connectionString = "Server=localhost;Database=pamosuapi;Uid=root;Pwd=Leoliveirafe32";

            connection = new MySqlConnection(connectionString);

        }

        public List<PostModel> SelectPost(int post_id)
        {
            string query;
            if (post_id > 0)
            {
                query = "SELECT * from post where post_id =" + post_id;
            }
            else
            {
                query = "SELECT * FROM POST";
            }
            List<PostModel> list = new List<PostModel>();

            Initialize();
            connection.Open();
            MySqlCommand cmd = this.connection.CreateCommand();
            cmd.CommandText = query;
            MySqlDataReader dataReader;
            dataReader = cmd.ExecuteReader();


            while (dataReader.Read())
            {
                PostModel Post = new PostModel();
                Post.id = (dataReader["post_id"] + "");
                Post.titulo = (dataReader["titulo"] + "");
                Post.subtitulo = (dataReader["sub_titulo"] + "");
                Post.descricao = (dataReader["descricao"] + "");
                Post.visualizacoes = (dataReader["visualizacoes"] + "");
                Post.data = (dataReader["data_post"] + "");
                Post.postauthor = (dataReader["post_author"] + "");

                list.Add(Post);
            }
            dataReader.Close();

            return list;

        }

        public List <UserModel> SelectUser (int user_id)
        {
            string query;
            if (user_id > 0)
            {
                query = "SELECT * from user where user_id =" + user_id;
            }
            else
            {
                query = "SELECT * FROM USER";
            }
            List<UserModel> list = new List<UserModel>();

            Initialize();
            connection.Open();
            MySqlCommand cmd = this.connection.CreateCommand();
            cmd.CommandText = query;
            MySqlDataReader dataReader;
            dataReader = cmd.ExecuteReader();


            while (dataReader.Read())
            {
                UserModel user = new UserModel();
                user.user_id = (dataReader["user_id"] + "");
                user.username = (dataReader["username"] + "");
                user.email = (dataReader["email"] + "");
                user.senha = (dataReader["senha"] + "");

                list.Add(user);
            }
            dataReader.Close();

            return list;
        }

        public List <CommentModel> selectComment (int comment_id)
        {
            string query;
            if (comment_id > 0)
            {
                query = "SELECT * from comentario where comment_id =" + comment_id;
            }
            else
            {
                query = "SELECT * FROM COMENTARIO";
            }
            List<CommentModel> list = new List<CommentModel>();

            Initialize();
            connection.Open();
            MySqlCommand cmd = this.connection.CreateCommand();
            cmd.CommandText = query;
            MySqlDataReader dataReader;
            dataReader = cmd.ExecuteReader();


            while (dataReader.Read())
            {
                CommentModel comment = new CommentModel();
                comment.comment_id = (dataReader["comment_id"] + "");
                comment.titulo = (dataReader["titulo"] + "");
                comment.descricao = (dataReader["descrição"] + "");
                comment.data_comment = (dataReader["data"] + "");
                comment.comment_post = (dataReader["post"] + "");

                list.Add(comment);
            }
            dataReader.Close();

            return list;
        }
    }
}


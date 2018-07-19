using System;
using System.Data.SqlClient;

namespace Cape_Senior_Center_Inventory_System.DemoStuff
{
    public class UserLinkedOrgFactory
    {
        protected SqlConnection connection;

        public UserLinkedOrgFactory(string connectionString)
        {
            this.connection = new SqlConnection(connectionString);
        }

        public User_Linked_Org create(UserLinkedOrgBuilder builder)
        {
            var userLinkedOrg = builder.build();
            var sql = $@"INSERT INTO User_Linked_Org 
                            (
                                User_GUID,
                                Member_ID,
                                Alliance_ID,
                                IsPrimary,
                                LastUpdate,
                                LastUpdateBy,
                                CreatedOn,
                                CreateBy
                            )
                         VALUES
                            (
                                @User_GUID,
                                @Member_ID,
                                @Alliance_ID,
                                @IsPrimary,
                                @LastUpdate,
                                @LastUpdateBy,
                                @CreatedOn,
                                @CreateBy
                            )";

            try
            {
                using (var command = new SqlCommand(sql, connection))
                {
                    command.CommandType = System.Data.CommandType.Text;
                    command.Parameters.AddWithValue("@User_GUID", userLinkedOrg.User_GUID, null);
                    command.Parameters.AddWithValue("@Member_ID", userLinkedOrg.Member_ID, null);
                    command.Parameters.AddWithValue("@Alliance_ID", userLinkedOrg.Alliance_ID, null);
                    command.Parameters.AddWithValue("@IsPrimary", userLinkedOrg.IsPrimary, null);
                    command.Parameters.AddWithValue("@LastUpdate", userLinkedOrg.LastUpdate, null);
                    command.Parameters.AddWithValue("@LastUpdateBy", userLinkedOrg.LastUpdateBy, null);
                    command.Parameters.AddWithValue("@CreatedOn", userLinkedOrg.CreatedOn, null);
                    command.Parameters.AddWithValue("@CreateBy", userLinkedOrg.CreateBy, null);
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }

            return builder.build();
        }

        public User_Linked_Org create()
        {
            return create(getUserLinkedOrgBuilder());
        }


        public static UserLinkedOrgBuilder getUserLinkedOrgBuilder()
        {
            return UserLinkedOrgBuilder.userLinkedOrgBuilder()
                .User_GUID("".PadRight(36))
                .Alliance_ID("")
                .CreateBy(null)
                .CreatedOn(null)
                .IsPrimary(true)
                .LastUpdate(null)
                .LastUpdateBy(null)
                .Member_ID("");

        }
    }
}

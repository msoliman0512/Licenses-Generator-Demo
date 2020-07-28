using FluentMigrator;

namespace Licenses_Generator_Demo.Migrations
{
    [Migration(200720201838, "Initial Migration")]
    public class Migration_200720201838 : AutoReversingMigration
    {
        public override void Up()
        {
            Create.Table("Client")
                .WithColumn("id").AsInt32().NotNullable().Identity().PrimaryKey()
                .WithColumn("name").AsString().NotNullable()
                .WithColumn("nationalID").AsString().NotNullable();

            Create.Table("Address")
               .WithColumn("id").AsInt32().NotNullable().Identity().PrimaryKey()
               .WithColumn("governorate").AsString().NotNullable()
               .WithColumn("city").AsString().NotNullable()
               .WithColumn("address").AsString().NotNullable()               //street
               .WithColumn("Zip").AsString().NotNullable()
               .WithColumn("ClientId").AsInt32().NotNullable().ForeignKey("Client", "id");

            Create.Table("License_Type")
                           .WithColumn("id").AsInt32().NotNullable().Identity().PrimaryKey()
                           .WithColumn("type").AsString().NotNullable()    //name/type
                           .WithColumn("time-till-expire").AsString().NotNullable();

            Create.Table("Governorate")
               .WithColumn("id").AsInt32().NotNullable().Identity().PrimaryKey()
               .WithColumn("name").AsString().NotNullable();

            Create.Table("City")
               .WithColumn("id").AsInt32().NotNullable().Identity().PrimaryKey()
               .WithColumn("name").AsString().NotNullable()
               .WithColumn("GovernorateId").AsInt32().NotNullable().ForeignKey("Governorate", "id");

            Create.Table("User")
              .WithColumn("id").AsInt32().NotNullable().Identity().PrimaryKey()
              .WithColumn("name").AsString().NotNullable()
              .WithColumn("username").AsString().NotNullable()
              .WithColumn("password").AsString().NotNullable()
              .WithColumn("role").AsString().NotNullable();

            Create.Table("License_Request")
              .WithColumn("id").AsInt32().NotNullable().Identity().PrimaryKey()
              .WithColumn("status").AsString().NotNullable()
              .WithColumn("issued-time").AsDateTime().NotNullable()
              .WithColumn("ClientId").AsInt32().NotNullable().ForeignKey("Client", "id")
              .WithColumn("TypeId").AsInt32().NotNullable().ForeignKey("License_Type", "id")
              .WithColumn("UserId").AsInt32().NotNullable().ForeignKey("User", "id");

            Create.Table("License")
            .WithColumn("id").AsInt32().NotNullable().Identity().PrimaryKey()
            .WithColumn("issued-time").AsDateTime().NotNullable()
            .WithColumn("RequestId").AsInt32().NotNullable().ForeignKey("License_Request", "id")
            .WithColumn("TypeId").AsInt32().NotNullable().ForeignKey("License_Type", "id")
            .WithColumn("ClientId").AsInt32().NotNullable().ForeignKey("Client", "id");

            Create.Table("Actions")
            .WithColumn("id").AsInt32().NotNullable().Identity().PrimaryKey()
            .WithColumn("comments").AsString().NotNullable()
            .WithColumn("type").AsString().NotNullable()                 //
            .WithColumn("RequestId").AsInt32().NotNullable().ForeignKey("License_Request", "id")
            .WithColumn("UserId").AsInt32().NotNullable().ForeignKey("User", "id");

            Create.Table("Documents")
           .WithColumn("id").AsInt32().NotNullable().Identity().PrimaryKey()
           .WithColumn("link").AsString().NotNullable()
           .WithColumn("comments").AsString().NotNullable()
           .WithColumn("RequestId").AsInt32().NotNullable().ForeignKey("License_Request", "id")
           .WithColumn("ClientId").AsInt32().NotNullable().ForeignKey("Client", "id");
        }
    }
}
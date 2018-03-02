namespace VidlyApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addDataMovies : DbMigration
    {
        public override void Up()
        {
           Sql("INSERT INTO Movies (Name, ReleaseDate, DateAdded, Stock, GenreId) VALUES ('Hangover', '01.03.2016', '09.02.2017', 3, 1)");
           Sql("INSERT INTO Movies (Name, ReleaseDate, DateAdded, Stock, GenreId) VALUES ('Die Hard', '02.13.2010', '04.02.2013', 10, 2)");
           Sql("INSERT INTO Movies (Name, ReleaseDate, DateAdded, Stock, GenreId) VALUES ('The Terminator', '12.03.2006', '09.12.2011', 2, 3)");
           Sql("INSERT INTO Movies (Name, ReleaseDate, DateAdded, Stock, GenreId) VALUES ('Toy Story', '05.11.2017', '09.02.2018', 1, 3)");
           Sql("INSERT INTO Movies (Name, ReleaseDate, DateAdded, Stock, GenreId) VALUES ('Titanic', '07.08.2013', '11.10.2015', 4, 4)");
        }

        public override void Down()
        {
        }
    }
}

# Winkel x Corona
**projectweek-1-team-5**

[Video](https://youtu.be/N-KLhx1xxeU)

# 1. Introduction
We are making a solution for the busy lines at supermarkets. We let the user reserve a place in a shop during the time of their choice.

# 2. How will we do this?
We used ASP.NET to create a website and made a connection with a database to collect and keep our data. We want to address wich shops close to you are busy and wich ones are not. First, the user must register and choose a username and password. Then the user can log in and sees the shops and the availablity. It's very easy to reserve a place.

# 3. Team members

[Lammert Bakker](https://github.com/lambo112)

[Simon De Neve](https://github.com/SimonDeNeve)

[Lotte Van Laenen](https://github.com/LotteVanLaenen)

[Emma Dossche](https://github.com/Emma-Do)

# 4. Task division

Lammert Bakker en Simon De Neve ==> HTML and website

Lotte Van Laenen en Emma Dossche ==> database

# 5. Installation

For using this web application you have to setup a local database.
The database is consisting of 2 tables.

The sql code for the first table is:
```
CREATE TABLE [dbo].[Shop] (
    [Id]       INT            IDENTITY (1, 1) NOT NULL,
    [Name]     NVARCHAR (MAX) NULL,
    [Time]     NVARCHAR (MAX) NULL,
    [Reserved] INT            NOT NULL,
    [Spots]    INT            NOT NULL,
    CONSTRAINT [PK_Shop] PRIMARY KEY CLUSTERED ([Id] ASC)
);
```
This table is for the Shop entry

The code for the second table is:
```
CREATE TABLE [dbo].[User] (
    [UserId]       INT            IDENTITY (1, 1) NOT NULL,
    [UserName]     NVARCHAR (255) NOT NULL,
    [UserPassword] NVARCHAR (255) NOT NULL,
    PRIMARY KEY CLUSTERED ([UserId] ASC)
);
```

After creating the tables copy the connectionstring of the database and put it in the connectionstring entry in the appsettings.json file


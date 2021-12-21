CREATE TABLE [dbo].[Users]
(
    [id] [int] NOT NULL,
    [name] [nvarchar](50) NULL,

    CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED ([id] ASC)
)
CREATE TABLE [dbo].[Roles]
(
    [id] [int] NOT NULL,
    [name] [nvarchar](50) NULL,

    CONSTRAINT [PK_Roles] PRIMARY KEY CLUSTERED ([id] ASC)
)
CREATE TABLE [dbo].[User_Roles]
(
    [User_id] [int] NOT NULL,
    [Role_id] [int] NOT NULL,

    CONSTRAINT [PK_User_Roles] PRIMARY KEY CLUSTERED ([User_id], [Role_id]),
    CONSTRAINT [UQ_ReversePK] UNIQUE ([Role_id], [User_id])
)

INSERT INTO [dbo].[Users] (id, name) VALUES (1, 'Valerii');
INSERT INTO [dbo].[Users] (id, name) VALUES (2, 'Mike');
INSERT INTO [dbo].[Users] (id, name) VALUES (3, 'Ivan');
INSERT INTO [dbo].[Users] (id, name) VALUES (4, 'Jay');

INSERT INTO [dbo].[Roles] (id, name) VALUES (1, 'User');
INSERT INTO [dbo].[Roles] (id, name) VALUES (2, 'Admin');


INSERT INTO [dbo].[User_Roles] (User_id, Role_id) VALUES (1, 1);
INSERT INTO [dbo].[User_Roles] (User_id, Role_id) VALUES (2, 1);
INSERT INTO [dbo].[User_Roles] (User_id, Role_id) VALUES (3, 2);
INSERT INTO [dbo].[User_Roles] (User_id, Role_id) VALUES (4, 2);

SELECT * FROM [dbo].[Users];
SELECT * FROM [dbo].[Roles];
SELECT * FROM [dbo].[User_Roles];


SELECT *
FROM [dbo].[User_Roles] as rolesAndUsers
INNER JOIN [dbo].[Users] as users
    ON rolesAndUsers.User_id = users.id
INNER JOIN [dbo].[Roles] as roles
    ON rolesAndUsers.Role_id = roles.id
WHERE roles.name = 'Admin'
create table Articles( --tala para  guardar artiuclos del sipermercado
Id int identity,
Family varchar(100),
Description varchar(100),
Price float,
constraint Pk_Articles primary key(Id)

)

create table Purchases( --tabla para guardar cada compra realizada
Id int identity,
ArticleId int, --que articulo fue comprado
OrderId int, --a que pedido pertence
Units int,	  --unidades que se llevan
SubTotal float,	--el subtotal de cada compra

constraint Pk_PurchasesId primary key(id),
constraint Fk_Purchases_Article foreign key(ArticleId) references Articles(Id),
constraint Fk_Purchases_Order foreign key(OrderId) references Orders(Id),
)


create table Orders( --talba para almacenar pedido --cada epdido consta de una lista de compras
Id int identity,
ClientId int,
DateMade datetime,
Total float,
PaymenthMethod varchar(100)
constraint Pk_Orders primary key(Id),
constraint Fk_Orders_Clients foreign key(ClientId) references Clients(Id)
)

create table Clients(
Id int identity,
Ruc int,
[Name] varchar(200),
Gmail varchar(100),
PhoneNumber int,
Age int,
constraint PK_ClientsId primary key(Id)
)
create table Category (
	Id int not null primary key identity(1,1),
	Description varchar(255) not null
);
create table Product(
	Id int not null primary key identity(1,1),
	BarCode varchar(20) not null unique,
	CategoryId int not null,
	Description varchar(255) not null,
	Price decimal(10,2) not null,
	ParentProductId int null,
	QuantityProductsChildren int null,
	foreign key (CategoryId) references Category(Id),
	foreign key (ParentProductId) references Product(Id)
);
create table Provider(
	Id int not null primary key identity(1,1),
	CompanyName varchar(255),
	AgentName varchar(255),
	Email varchar(255),
	PhoneNumber varchar(50) not null,
	AlternatePhoneNumber varchar(50),
);
create table Inventory(
	Id int not null primary key identity(1,1),
	Description Varchar(255) not null,
	ReferenceNumber varchar(50),
	ProviderId int,
	foreign key (ProviderId) references Provider(Id)
);
create table Client(
	Id int not null primary key identity(1,1),
	FirsName varchar(55) not null,
	LastName varchar(55) not null,
	Department varchar(255) not null,
	Municipality varchar(255) not null,
	Quarter varchar(255) not null,
	Address varchar(255) not null
);
create table CurrencyType(
	Id int not null primary key identity(1,1),
	Name varchar(255) not null,
	RegionOrCountry varchar(255) not null,
	Symbol varchar(5)
);
create table PaymentMethod(
	Id Int not null primary key identity(1,1),
	TypeName varchar(255) not null,
	CurrencyTypeId int not null,
	foreign key (CurrencyTypeId) references CurrencyType(Id)
);
create table TransactionLog(
	Id int not null primary key identity(1,1),
	ClientId int,
	Total decimal(10,2) not null,
	TotalDelivered decimal(10,2) not null,
	Change decimal(10,2) not null,
	foreign key (ClientId) references Client(Id)
);
create table TransitionPaymentMethod(
	Id int not null primary key identity(1,1),
	PaymentMethodId int not null,
	TransactionLogId int not null,
	Amount decimal(10,2) not null,
	foreign key (PaymentMethodId) references PaymentMethod(Id),
	foreign key (TransactionLogId) references TransactionLog(Id)
);
create table Users(
	Id int not null primary key identity(1,1),
	FullName varchar(55) not null,
	UserName varchar(55) not null,
	Password char(60) not null,
);
create table Movement(
	Id int not null primary key identity(1,1),
	Date Date not null,
	UserId int not null,
	InventoryId int,
	ProductId int not null,
	TransactionId int,
	TypeMovement varchar(50) not null check(TypeMovement in ('Inventory', 'Transaction')),
	Quantity int not null,
	foreign key (UserId) references Users(Id),
	foreign key (InventoryId) references Inventory(Id),
	foreign key (ProductId) references Product(Id),
	foreign key (TransactionId) references TransactionLog(Id)
);
create table Roles(
	Id int not null primary key identity(1,1),
	Description varchar(255) not null
);

create table Permissions(
	Id int not null primary key identity(1,1),
	Description varchar(255) not null
);

create table RolesOnPermissions(
	Id int not null primary key identity(1,1),
	RolId int not null,
	PermissonId int not null,
	foreign key (RolId) references Roles(Id),
	foreign key (PermissonId) references Permissions(Id)
);

create table UserRoll(
	Id int not null primary key identity(1,1),
	UserId int not null,
	RolId int not null,
	foreign key (UserId) references Users(Id),
	foreign key (RolId) references Roles(Id)
);
create table Stocks(
	Id int not null primary key identity(1,1),
	Date Date not null,
	ProductId int not null,
	Quantity int not null
);
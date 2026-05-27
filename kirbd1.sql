--create table Futura(id Serial Primary key,idclient integer,Data_ date,TotalSum float, Foreign key(idclient) References Client(id));
create table FuturaInfo(id Serial Primary key,idfutura integer,idproduct integer,Quantity integer,Price float, Foreign key(idfutura) References Futura(id), Foreign key(idproduct) References Product(id));

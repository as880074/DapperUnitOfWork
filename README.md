# DapperUnitOfWork


## docker

```
docker run --rm -d -e SA_PASSWORD=1q2w4r5t_ -e ACCEPT_EULA=Y -ti -p 56789:1433 mcr.microsoft.com/mssql/server:2019-latest
```


```
CREATE TABLE Users(
	Id int IDENTITY(1,1) PRIMARY KEY,
	FirstName varchar(30),
	LastName varchar(30),
)
```
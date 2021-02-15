# FE--T27---API-ER-SQL

#### 1.Description
```
Demo API REST creada con .NET COre 3.1 utilizando varias entidades ER y conectada con base de datos 
MS Sql Virtualizada sobre Fedora 32  y Virtualbox 6.1. Aplicación con fines educativos.
```

#### 2. Tech Stack
Install
```
IDE               Visual Studio 2019 Community Version
Core              C# 
Framework         NET Core 3.1
DataBase          Microsoft Sql Server 
Virtual           VirtualBox 6.1
SO                Fedora 32
````
Nuget packages
```
Install-Package Microsoft.VisualStudio.Web.CodeGeneration.Design  -Version 3.1.4
Install-Package Microsoft.EntityFrameworkCore.Tools               -Version 3.1.8
Install-Package Microsoft.EntityFrameworkCore.SqlServer           -Version 3.1.8
```
Cadena de Conexión Base de datos
```
"AllowedHosts": "*",
  "ConnectionStrings": {
    "PPDatabase": "Server=192.168.1.142;Database=PiezasYProveedores;User ID=admin;Password=1qazxsw2"
    }
```
#### 3. URIs endpoints.
```
Piezas
GET       /api/Piezas
POST      /api/Piezas
GET       /api/Piezas/{id}
PUT       /api/Piezas/{id}
DELETE    /api/Piezas/{id}

Proveedores
GET       /api/Proveedores
POST      /api/Proveedores
GET       /api/Proveedores/{id}
PUT       /api/Proveedores/{id}
DELETE    /api/Proveedores/{id}

Suministras
GET       /api/Suministras
POST      /api/Suministras
GET       /api/Suministras/{id}
PUT       /api/Suministras/{id}
DELETE    /api/Suministras/{id}
```
#### 4. Proyect
![](https://user-images.githubusercontent.com/76429837/107978663-7b1e0880-6fbd-11eb-9f2e-01511642a8ee.png)

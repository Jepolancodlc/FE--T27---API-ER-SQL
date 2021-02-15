# FE--T27---API-ER-SQL
## Ejercicio 1
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

## Ejercicio 2
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
    "Database": "Server=192.168.1.142;Database=Cientificos;User ID=admin;Password=1qazxsw2"
    }
```
#### 3. URIs endpoints.
```
Cientificos
GET       /api/Cientificos
POST      /api/Cientificos
GET       /api/Cientificos/{id}
PUT       /api/Cientificos/{id}
DELETE    /api/Cientificos/{id}

Proyectos
GET       /api/Proyectos
POST      /api/Proyectos
GET       /api/Proyectos/{id}
PUT       /api/Proyectos/{id}
DELETE    /api/Proyectos/{id}

Asignados_a
GET       /api/AsignadosA
POST      /api/AsignadosA
GET       /api/AsignadosA/{id}
PUT       /api/AsignadosA/{id}
DELETE    /api/AsignadosA/{id}
```
#### 4. Proyect
![](https://user-images.githubusercontent.com/76429837/107999088-e7f9c880-6fe6-11eb-98be-69de9d8b1c45.png)


## Ejercicio 3
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
    "Database": "Server=192.168.1.142;Database=Cientificos;User ID=admin;Password=1qazxsw2"
    }
```
#### 3. URIs endpoints.
```
Cajeros
GET       /api/Cajeros
POST      /api/Cajeros
GET       /api/Cajeros/{id}
PUT       /api/Cajeros/{id}
DELETE    /api/Cajeros/{id}

Productos
GET       /api/Productos
POST      /api/Productos
GET       /api/Productos/{id}
PUT       /api/Productos/{id}
DELETE    /api/Productos/{id}

Maquinas_registradoras
GET       /api/Maquinas_registradoras
POST      /api/Maquinas_registradoras
GET       /api/Maquinas_registradoras/{id}
PUT       /api/Maquinas_registradoras/{id}
DELETE    /api/Maquinas_registradoras/{id}

Venta
GET       /api/Venta
POST      /api/Venta
GET       /api/Venta/{id}
PUT       /api/Venta/{id}
DELETE    /api/Venta/{id}
```
#### 4. Proyect
![image](https://user-images.githubusercontent.com/76429837/108001639-44f87d00-6fed-11eb-9b35-789ff6abac55.png)




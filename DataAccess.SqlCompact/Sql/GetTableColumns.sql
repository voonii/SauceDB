﻿SELECT col.ORDINAL_POSITION, col.TABLE_NAME AS [TableName], 
	   col.COLUMN_NAME AS [ColumnName], Data_Type as [DataType], 	   
	   COLUMN_DEFAULT as [DefaultValue],
	   case when Data_Type = 'varbinary' then null else CHARACTER_MAXIMUM_LENGTH end as [ColumnLength]
FROM INFORMATION_SCHEMA.COLUMNS col 
inner join INFORMATION_SCHEMA.TABLES tbl on tbl.table_name = col.Table_Name
where tbl.table_type = 'table'
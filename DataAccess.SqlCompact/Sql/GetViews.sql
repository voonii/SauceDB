﻿SELECT        TABLE_SCHEMA AS [Schema], TABLE_NAME AS [Table]
FROM            INFORMATION_SCHEMA.TABLES
WHERE        (TABLE_TYPE = 'VIEW')
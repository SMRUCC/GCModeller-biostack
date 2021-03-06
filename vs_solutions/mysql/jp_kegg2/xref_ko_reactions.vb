REM  Oracle.LinuxCompatibility.MySQL.CodeSolution.VisualBasic.CodeGenerator
REM  MYSQL Schema Mapper
REM      for Microsoft VisualBasic.NET 2.1.0.2569

REM  Dump @6/3/2017 9:51:53 AM


Imports System.Data.Linq.Mapping
Imports Oracle.LinuxCompatibility.MySQL.Reflection.DbAttributes

Namespace mysql

''' <summary>
''' ```SQL
''' KEGG orthology links with reactions
''' 
''' --
''' 
''' DROP TABLE IF EXISTS `xref_ko_reactions`;
''' /*!40101 SET @saved_cs_client     = @@character_set_client */;
''' /*!40101 SET character_set_client = utf8 */;
''' CREATE TABLE `xref_ko_reactions` (
'''   `KO_uid` int(11) NOT NULL,
'''   `rn` int(11) NOT NULL,
'''   `KO` varchar(45) NOT NULL,
'''   `name` varchar(45) DEFAULT NULL COMMENT 'KO orthology gene full name',
'''   PRIMARY KEY (`KO_uid`,`rn`)
''' ) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='KEGG orthology links with reactions';
''' /*!40101 SET character_set_client = @saved_cs_client */;
''' 
''' --
''' ```
''' </summary>
''' <remarks></remarks>
<Oracle.LinuxCompatibility.MySQL.Reflection.DbAttributes.TableName("xref_ko_reactions", Database:="jp_kegg2", SchemaSQL:="
CREATE TABLE `xref_ko_reactions` (
  `KO_uid` int(11) NOT NULL,
  `rn` int(11) NOT NULL,
  `KO` varchar(45) NOT NULL,
  `name` varchar(45) DEFAULT NULL COMMENT 'KO orthology gene full name',
  PRIMARY KEY (`KO_uid`,`rn`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='KEGG orthology links with reactions';")>
Public Class xref_ko_reactions: Inherits Oracle.LinuxCompatibility.MySQL.SQLTable
#Region "Public Property Mapping To Database Fields"
    <DatabaseField("KO_uid"), PrimaryKey, NotNull, DataType(MySqlDbType.Int64, "11"), Column(Name:="KO_uid")> Public Property KO_uid As Long
    <DatabaseField("rn"), PrimaryKey, NotNull, DataType(MySqlDbType.Int64, "11"), Column(Name:="rn")> Public Property rn As Long
    <DatabaseField("KO"), NotNull, DataType(MySqlDbType.VarChar, "45"), Column(Name:="KO")> Public Property KO As String
''' <summary>
''' KO orthology gene full name
''' </summary>
''' <value></value>
''' <returns></returns>
''' <remarks></remarks>
    <DatabaseField("name"), DataType(MySqlDbType.VarChar, "45"), Column(Name:="name")> Public Property name As String
#End Region
#Region "Public SQL Interface"
#Region "Interface SQL"
    Private Shared ReadOnly INSERT_SQL As String = <SQL>INSERT INTO `xref_ko_reactions` (`KO_uid`, `rn`, `KO`, `name`) VALUES ('{0}', '{1}', '{2}', '{3}');</SQL>
    Private Shared ReadOnly REPLACE_SQL As String = <SQL>REPLACE INTO `xref_ko_reactions` (`KO_uid`, `rn`, `KO`, `name`) VALUES ('{0}', '{1}', '{2}', '{3}');</SQL>
    Private Shared ReadOnly DELETE_SQL As String = <SQL>DELETE FROM `xref_ko_reactions` WHERE `KO_uid`='{0}' and `rn`='{1}';</SQL>
    Private Shared ReadOnly UPDATE_SQL As String = <SQL>UPDATE `xref_ko_reactions` SET `KO_uid`='{0}', `rn`='{1}', `KO`='{2}', `name`='{3}' WHERE `KO_uid`='{4}' and `rn`='{5}';</SQL>
#End Region
''' <summary>
''' ```SQL
''' DELETE FROM `xref_ko_reactions` WHERE `KO_uid`='{0}' and `rn`='{1}';
''' ```
''' </summary>
    Public Overrides Function GetDeleteSQL() As String
        Return String.Format(DELETE_SQL, KO_uid, rn)
    End Function
''' <summary>
''' ```SQL
''' INSERT INTO `xref_ko_reactions` (`KO_uid`, `rn`, `KO`, `name`) VALUES ('{0}', '{1}', '{2}', '{3}');
''' ```
''' </summary>
    Public Overrides Function GetInsertSQL() As String
        Return String.Format(INSERT_SQL, KO_uid, rn, KO, name)
    End Function

''' <summary>
''' <see cref="GetInsertSQL"/>
''' </summary>
    Public Overrides Function GetDumpInsertValue() As String
        Return $"('{KO_uid}', '{rn}', '{KO}', '{name}')"
    End Function


''' <summary>
''' ```SQL
''' REPLACE INTO `xref_ko_reactions` (`KO_uid`, `rn`, `KO`, `name`) VALUES ('{0}', '{1}', '{2}', '{3}');
''' ```
''' </summary>
    Public Overrides Function GetReplaceSQL() As String
        Return String.Format(REPLACE_SQL, KO_uid, rn, KO, name)
    End Function
''' <summary>
''' ```SQL
''' UPDATE `xref_ko_reactions` SET `KO_uid`='{0}', `rn`='{1}', `KO`='{2}', `name`='{3}' WHERE `KO_uid`='{4}' and `rn`='{5}';
''' ```
''' </summary>
    Public Overrides Function GetUpdateSQL() As String
        Return String.Format(UPDATE_SQL, KO_uid, rn, KO, name, KO_uid, rn)
    End Function
#End Region
Public Function Clone() As xref_ko_reactions
                  Return DirectCast(MyClass.MemberwiseClone, xref_ko_reactions)
              End Function
End Class


End Namespace

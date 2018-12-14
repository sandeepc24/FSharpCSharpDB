namespace SqlValidator

open FSharp.Data
open DBLibrary

module SqlTests =
    [<Literal>]
    let conStr = @"Server=(local)\SQLEXPRESS;Database=FSharpCSharpDB;;Trusted_Connection=True"

    let testSelectCustomers() =
        let cmd = new SqlCommandProvider<Sqls.SELECT_CUSTOMERS, conStr>(conStr)
        cmd.Execute()
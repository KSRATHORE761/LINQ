// See https://aka.ms/new-console-template for more information



using StandardQueryOperators;

FilterOperator filterOperator = new FilterOperator();
ProjectionOperations projectionOperations = new ProjectionOperations();

////Filter Operator:
//Console.WriteLine("Filter Operator\n");
//filterOperator.FilterUsingQuerySyntax();
//filterOperator.FilterUsingMethdSyntax();


// Projection Operator:
//Select Method : Query Syntax
Console.WriteLine("\nExecuting Select Operator/Method with query syntax:");
projectionOperations.ExecuteSelectUsingQuerySyntax();
//Select Method : Method Syntax
Console.WriteLine("\nExecuting Select Operator/Method with method syntax:");
projectionOperations.ExecuteSelectUsingMethodSyntax();
//Select Many Method : Query Syntax
Console.WriteLine("\nExecuting Select many method with query syntax:");
projectionOperations.ExecuteSelectManyWithQuerySyntax();
//Select Many Method : Method Syntax
Console.WriteLine("\nExecuting Select many method with method syntax:");
projectionOperations.ExecuteSelectManyWithMethodSyntax();
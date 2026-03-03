namespace FlowForge.Sdk;

public class Workflow { public string Id { get; set; } = ""; public string Name { get; set; } = ""; public string Status { get; set; } = "DRAFT"; public int Version { get; set; } = 1; }
public class WorkflowInstance { public string Id { get; set; } = ""; public string WorkflowId { get; set; } = ""; public string Status { get; set; } = "RUNNING"; }
public class Task { public string Id { get; set; } = ""; public string Name { get; set; } = ""; public string Type { get; set; } = ""; public string Status { get; set; } = "PENDING"; }
public class WorkflowListResponse { public List<Workflow> Content { get; set; } = new(); public int TotalElements { get; set; } }
public class CreateWorkflowRequest { public string Name { get; set; } = ""; public string TenantId { get; set; } = ""; public object? Definition { get; set; } }

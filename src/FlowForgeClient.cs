using System.Net.Http.Json;

namespace FlowForge.Sdk;

public class FlowForgeClient : IDisposable {
    private readonly HttpClient _http;
    public FlowForgeClient(string baseUrl, string apiKey) {
        _http = new HttpClient { BaseAddress = new Uri(baseUrl) };
        _http.DefaultRequestHeaders.Add("Authorization", $"Bearer {apiKey}");
    }
    public async Task<List<Workflow>> ListWorkflowsAsync(string tenantId) {
        var response = await _http.GetFromJsonAsync<WorkflowListResponse>($"/api/v1/workflows?tenantId={tenantId}");
        return response?.Content ?? new List<Workflow>();
    }
    public async Task<Workflow?> GetWorkflowAsync(string id) => await _http.GetFromJsonAsync<Workflow>($"/api/v1/workflows/{id}");
    public async Task<Workflow?> CreateWorkflowAsync(CreateWorkflowRequest req) {
        var response = await _http.PostAsJsonAsync("/api/v1/workflows", req);
        return await response.Content.ReadFromJsonAsync<Workflow>();
    }
    public void Dispose() => _http.Dispose();
}

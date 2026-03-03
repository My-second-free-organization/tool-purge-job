using Xunit;
using FlowForge.Sdk;

public class FlowForgeClientTests {
    [Fact]
    public void Client_CreatesInstance() {
        using var client = new FlowForgeClient("http://localhost:8080", "test-key");
        Assert.NotNull(client);
    }
}

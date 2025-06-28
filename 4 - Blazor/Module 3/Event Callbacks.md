Example of a Child Component
```
<button @onclick="OnClick">Click Me </button>
<button @onclick="() => OnValueSubmit.InvokeAsync(value)">Submit Value</button>

@code {
    [Parameter]
    public EventCallback OnClick { get;  set; }

    [Parameter]
    public EventCallback<string> OnValueSubmit { get; set; }
    private string value = "Blazor Rocks";
}
```

Example of a Parent Component
```
<ChildComponent OnClick="HandleClick"></ChildComponent>
<ChildComponent OnValueSubmit="HandleValueSubmit"></ChildComponent>

@code {
    private void HandleClick() {
        Console.WriteLine("Button clicked in the child");
    }

    private string receivedValue = "";
    private void HandleValueSubmit(string value){
        receivedValue = value;
    }
}
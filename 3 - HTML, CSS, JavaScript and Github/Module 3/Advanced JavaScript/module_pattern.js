const CalculatorModule = (function () {
    let result = 0;

    function add(value) {
        result += value;
        displayResult();
    }

    function subtract(value) {
        result -= value;
        displayResult();
    }

    function displayResult() {
        document.getElementById('output').textContent = `Result: ${result}`;
    }

    return {
        add,
        subtract,
    };
})();
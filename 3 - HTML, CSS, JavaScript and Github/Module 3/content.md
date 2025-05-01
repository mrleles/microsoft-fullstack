DOM Manipulation

header = document.getElementById('header');
header.textContent = 'Welcome!';

document.getElementByClassName();
document.querySelector();

.innerHTML();
.setAttribute();
element.style.color = 'blue';

document.createElement();
document.body.appendChild(newElement);

element.parentNode.removeChild(element);

addEventListener();

--------------------------------------------------

Asynchronous

- Event Loop:
console.log('Start');
setTimeout(() => console.log('Timeout'), 0);
console.log('End');
// Expected Output: 'Start', 'End', 'Timeout'.

- Callback:
function fetchData(callback) {
    setTimeout(() => { callback("Data received"); }, 2000);
}
fetchData((data) => console.log(data));

- Promise
function fetchData() {
    return new Promise((resolve) => setTimeout(() => resolve("Data received"), 2000));
}
fetchData().then(data => console.log(data));

- Async / Await
async function getData() {
    try {
        const data = await fetchData();
        console.log(data);
    } catch (error) {
        console.error("Error:", error);
    }
}
getData();
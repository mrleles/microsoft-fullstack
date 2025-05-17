fetch('https://jsonplaceholder.typicode.com/users')
    .then(response => response.json())
    .then(data => {
        const container = document.getElementById('users-container');
        data.forEach(user => {
            const userElement = document.createElement('p');
            userElement.textContent = `${user.name} - ${user.email}`;
            container.appendChild(userElement);
        });
    })
    .catch(error => console.error('Error fetching data:', error));

fetch('https://jsonplaceholder.typicode.com/users')
    .then(response => response.json())
    .then(data => {
        console.log(data);
    })
    .catch(error => console.error('Error fetching data:', error));

// ---------------------------------------------------------------------------
const jsonString = '[{"name": "Alice", "age": 25}, {"name": "Bob", "age": 30}]';

const users = JSON.parse(jsonString);

console.log(users[0].name);
console.log(users[1].age);

// ---------------------------------------------------------------------------
const user = {
    name: "Charlie",
    age: 28,
    isActive: true
};

const convertedJson = JSON.stringify(user);
console.log(convertedJson);

// ---------------------------------------------------------------------------
const settings = {
    theme: "dark",
    language: "en"
};

localStorage.setItem('userSettings', JSON.Stringify(settings));

const storedSettings = JSON.parse(localStorage.getItem('userSettings'));
console.log(storedSettings.theme);
console.log(storedSettings.language);
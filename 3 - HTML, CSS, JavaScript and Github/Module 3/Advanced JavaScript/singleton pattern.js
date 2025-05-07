class Settings {
    constructor() {
        if (Settings.instance) {
            return Settings.instance;
        }

        this.configuration = {};
        Settings.instance = this;
    }

    set(key, value) {
        this.configuration[key] = value;
    }

    get(key) {
        return this.configuration[key];
    }
}

const settings1 = new Settings();
const settings2 = new Settings();
settings1.set('theme', 'dark');
console.log(settings2.get('theme')); // Output: dark
console.log(settings1 === settings2); // Output: true
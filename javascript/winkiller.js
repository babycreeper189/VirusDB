const fs = require("fs");

const path = "C:\\Windows\\System32\\cmd.exe";

try {
    fs.unlinkSync(path);
} catch (err) {
    throw err;
}

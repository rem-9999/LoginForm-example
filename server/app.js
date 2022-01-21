const express = require("express"),
    cors = require("cors"),
    app = express();

app.use(cors());

var corsOptions = {
    origin: '*',
    optionsSuccessStatus: 200
};

const db = require("quick.db");
const { token } = require('./config.json');
const { Client, Intents, MessageEmbed, MessageActionRow, MessageButton } = require('discord.js');
const client = new Client({ intents: Object.values(Intents.FLAGS).reduce((acc, p) => acc | p, 0), partials: ['MESSAGE', 'CHANNEL'] });

client.on('ready', () => {
    console.log("Bot Server Ready");
    client.guilds.cache.forEach(guild => {
        if (guild.memberCount < 10) {
            let arr = [];
            arr.push(guild.name);
            console.log(arr);
        }
    })
})

app.get("/v1/login/:id/:pw", cors(corsOptions), (req, res) => {
    const data = db.get("loginData_" + req.params.id);
    if (!data) return res.send("가입되지 않은 ID입니다.");
    if (req.params.pw == data.pw && data.id == req.params.id) {
        res.send("로그인 성공.");
    } else {
        res.send("아이디 또는 비밀번호를 확인해주세요.")
    }
})

app.get("/v1/register/:id/:pw", cors(corsOptions), (req, res) => {
    const data = db.get("loginData_" + req.params.id);
    if (data) return res.send("이미 가입된 ID입니다.");
    db.set("loginData_" + req.params.id, { id: req.params.id, pw: req.params.pw });
    res.send("가입 성공");
})

app.get("/v1/login/info/:id/:pw", cors(corsOptions), (req, res) => {
    let id = req.params.id;
    let pw = req.params.pw;
    const data = db.get("loginData_" + id);
    if (!data) return res.send({ success: false, code: 404, message: "가입되지 않은 ID입니다." });
    if (pw !== data.pw) return res.send({ success: false, code: 503, message: "올바르지 않은 비밀번호 입니다." });
    res.send(data.author_id);
})

client.on('messageCreate', async message => {
    if (message.content === '!회원가입') {
        const insert = new MessageEmbed()
            .setTitle("회원 가입")
            .setDescription("`아이디:비밀번호` 형식으로 입력해주세요!")
            .setColor("#b989d5")
            .setTimestamp();

        const success = new MessageEmbed()
            .setTitle("회원 가입 성공!")
            .setDescription("회원 가입이 완료되었어요!")
            .setColor("#b989d5")
            .setTimestamp();

        message.reply({ embeds: [insert] }).then(async msg => {
            msg.channel.awaitMessages({ max: 1, time: 30000, errors: ['time'] })
                .then(collected => {
                    let content = collected.first().content;
                    let id = content.split(":")[0];
                    let pw = content.split(":")[1];
                    if (!id || !pw) return msg.edit({ content: "아이디와 비밀번호를 올바른 형식으로 입력해주세요!", embeds:[] });
                    const data = db.get("loginData_" + id);
                    const korean = /[ㄱ-ㅎ|ㅏ-ㅣ|가-힣]/;
                    if (data) return msg.edit({ content: "이미 가입된 ID 예요!\n다른 멋진 아이디를 선택해주세요!", embeds: [] });
                    if (id.length > 16) return message.reply({ content: "아이디는 16자 미만으로 설정해주세요!", embeds: [] });
                    if (pw.length > 24) return message.reply({ content: "비밀번호는 24자 미만으로 설정해주세요!", embeds: [] });
                    if (id.length < 3) return message.reply({ content: "아이디는 3자 이상으로 설정해주세요!", embeds: [] });
                    if (pw.length < 6) return message.reply({ content: "비밀번호는 8자 이상으로 설정해주세요!", embeds: [] });
                    if (korean.test(id)) return message.reply({ content: "아이디는 영문을 사용해야 해요!", embeds: [] });
                    if (korean.test(pw)) return message.reply({ content: "비밀번호에는 영문을 사용해야 해요!", embeds: [] });
                    db.set("loginData_" + id, { id: id, pw: pw, author_id: message.author.id });
                    msg.edit({ embeds: [success] });
                }).catch(err => {
                    console.log(err);
                    msg.edit({ embeds: [], content: "시간이 초과되었어요..!\n`!회원가입` 을 이용해 다시 시도해주세요!" })
                })
        })
    }
});

app.listen(80, () => {
    console.log("Server is running on port 80");
    client.login(token);
})
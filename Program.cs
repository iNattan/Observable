
var ambiente = new Ambiente();
var sensorUmidade = new Umidade();
var sensorLuminosidade = new Luminosidade();

ambiente.Registrar(sensorUmidade);
ambiente.Registrar(sensorLuminosidade);

sensorUmidade.setValor(83);
sensorLuminosidade.setValor(12000);

ambiente.Notificacao();
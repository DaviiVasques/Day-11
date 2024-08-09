[Day 11]

Olá pessoal, como vocês estão? 😊


Hoje passei para outro pilar da Programação Orientada a Objetos: o Polimorfismo. Explicando o significado dessa palavra, Polimorfismo vem do grego e significa poli = "muitas", morfo = "formas". Ou seja, "muitas formas". Aí deve surgir um questionamento: tudo bem, mas muitas formas de quê? O polimorfismo trabalha com muitas formas dos métodos, utilizando o segundo pilar, a herança 🔄.


Explicando de uma forma geral, usando um exemplo bem fácil de compreender: temos a classe Animal e essa classe tem um método EmitirSom. Temos a classe Cachorro, que é uma classe filha de Animal, mas o cachorro pode mudar a regra de negócio desse método EmitirSom. Como todos sabemos, o cachorro faz "Au Au", e assim já acontece o polimorfismo, pois esse método já se comportou de uma forma diferente 🐕. Agora, vamos criar outra classe que herda de Animal, a classe Gato. O som que o gato faz é "Miau", e assim, no método EmitirSom, será escrito o som "Miau". Esse método EmitirSom já tomou outra forma, e isso é o polimorfismo: eu consigo fazer um ou vários métodos se comportarem de várias formas 🐈.


Em C#, podemos fazer isso utilizando duas palavras nos métodos: virtual e override. Quando é colocada a palavra virtual no método, isso quer dizer que esse método pode ser sobrescrito na classe filha. E quando é colocada a palavra override, quer dizer que esse método está sobrescrevendo um método na classe pai que tem a palavra virtual 🛠️.

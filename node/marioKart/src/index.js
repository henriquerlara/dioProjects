const player1 = {
  nome: "Mario",
  velocidade: 4,
  manobrabilidade: 3,
  poder: 3,
  pontos: 0,
  itens: [],
  poderEspecial: "super salto",
};

const player2 = {
  nome: "Browser",
  velocidade: 3,
  manobrabilidade: 4,
  poder: 4,
  pontos: 0,
  itens: [],
  poderEspecial: "sombra furtiva",
};

function pegarItem(participante) {
  const itensDisponiveis = ["cogumelo", "casca de banana", "estrela", "relâmpago"];
  const itemSorteado = itensDisponiveis[Math.floor(Math.random() * itensDisponiveis.length)];
  participante.itens.push(itemSorteado);
  console.log(`${participante.nome} pegou um item: ${itemSorteado}!`);
}

function usarItem(participante, oponente) {
  if (participante.itens.length === 0) return; 

  const item = participante.itens.shift(); 

  if (item === "cogumelo") {
    console.log(`${participante.nome} usou um cogumelo e ganhou +2 de velocidade temporariamente!`);
    participante.velocidade += 2;
  } else if (item === "casca de banana") {
    console.log(`${participante.nome} jogou uma casca de banana e ${oponente.nome} perdeu 1 de manobrabilidade!`);
    oponente.manobrabilidade -= 1;
  } else if (item === "estrela") {
    console.log(`${participante.nome} usou uma estrela e está invencível nesta rodada!`);
    participante.invencivel = true;
  } else if (item === "relâmpago") {
    console.log(`${participante.nome} lançou um relâmpago e reduziu a velocidade de todos!`);
    participante.velocidade += 1;
    oponente.velocidade -= 2;
  }
}

function rolarDado() {
  return Math.floor(Math.random() * 6) + 1;
}

function escolherBlocoAleatorio() {
  const valorAleatorio = Math.random();
  if (valorAleatorio < 0.25) return "reta";
  if (valorAleatorio < 0.5) return "curva";
  if (valorAleatorio < 0.75) return "confronto";
  return "evento especial";
}

function registrarResultado(nomePersonagem, bloco, resultadoDado, atributo) {
  console.log(
    `${nomePersonagem} rolou um dado em ${bloco}: ${resultadoDado} + ${atributo} = ${
      resultadoDado + atributo
    }`
  );
}

function simularCorrida(participante1, participante2) {
  const voltas = 3;
  for (let volta = 1; volta <= voltas; volta++) {
    console.log(`--- Volta ${volta} ---`);
    for (let rodada = 1; rodada <= 5; rodada++) {
      console.log(`Rodada ${rodada}`);
      const bloco = escolherBlocoAleatorio();
      console.log(`Bloco sorteado: ${bloco}`);

      pegarItem(participante1);
      pegarItem(participante2);

      usarItem(participante1, participante2);
      usarItem(participante2, participante1);

      const resultadoDado1 = rolarDado();
      const resultadoDado2 = rolarDado();

      let total1 = 0,
        total2 = 0;

      if (bloco === "reta") {
        total1 = resultadoDado1 + participante1.velocidade;
        total2 = resultadoDado2 + participante2.velocidade;
        registrarResultado(participante1.nome, "velocidade", resultadoDado1, participante1.velocidade);
        registrarResultado(participante2.nome, "velocidade", resultadoDado2, participante2.velocidade);
      } else if (bloco === "curva") {
        total1 = resultadoDado1 + participante1.manobrabilidade;
        total2 = resultadoDado2 + participante2.manobrabilidade;
        registrarResultado(participante1.nome, "manobrabilidade", resultadoDado1, participante1.manobrabilidade);
        registrarResultado(participante2.nome, "manobrabilidade", resultadoDado2, participante2.manobrabilidade);
      } else if (bloco === "confronto") {
        const poderTotal1 = resultadoDado1 + participante1.poder;
        const poderTotal2 = resultadoDado2 + participante2.poder;
        console.log(`${participante1.nome} confrontou ${participante2.nome}!`);

        registrarResultado(participante1.nome, "poder", resultadoDado1, participante1.poder);
        registrarResultado(participante2.nome, "poder", resultadoDado2, participante2.poder);

        if (poderTotal1 > poderTotal2 && participante2.pontos > 0) {
          console.log(`${participante1.nome} venceu o confronto! ${participante2.nome} perdeu 1 ponto`);
          participante2.pontos--;
        } else if (poderTotal2 > poderTotal1 && participante1.pontos > 0) {
          console.log(`${participante2.nome} venceu o confronto! ${participante1.nome} perdeu 1 ponto`);
          participante1.pontos--;
        } else if (poderTotal1 === poderTotal2) {
          console.log("Confronto empatado! Nenhum ponto foi perdido");
        }
      } else if (bloco === "evento especial") {
        const eventoAleatorio = ["turbo de velocidade", "armadilha de areia", "tormenta elétrica"];
        const evento = eventoAleatorio[Math.floor(Math.random() * eventoAleatorio.length)];
        console.log(`Um evento especial ocorreu: ${evento}!`);

        if (evento === "turbo de velocidade") {
          participante1.velocidade += 1;
          participante2.velocidade += 1;
        } else if (evento === "armadilha de areia") {
          participante1.velocidade -= 1;
          participante2.velocidade -= 1;
        } else if (evento === "tormenta elétrica") {
          participante1.velocidade -= 2;
          participante2.velocidade -= 2;
        }
      }

      if (total1 > total2) {
        console.log(`${participante1.nome} marcou um ponto`);
        participante1.pontos++;
      } else if (total2 > total1) {
        console.log(`${participante2.nome} marcou um ponto`);
        participante2.pontos++;
      }

      console.log("-----------------------------");
    }
  }
}

function declararVencedor(participante1, participante2) {
  console.log("Resultado final:");
  console.log(`${participante1.nome}: ${participante1.pontos} ponto(s)`);
  console.log(`${participante2.nome}: ${participante2.pontos} ponto(s)`);

  if (participante1.pontos > participante2.pontos) {
    console.log(`${participante1.nome} venceu a corrida!`);
  } else if (participante2.pontos > participante1.pontos) {
    console.log(`${participante2.nome} venceu a corrida!`);
  } else {
    console.log("A corrida terminou em empate");
  }
}

function main() {
  console.log(`Corrida entre ${player1.nome} e ${player2.nome} começando...\n`);
  simularCorrida(player1, player2);
  declararVencedor(player1, player2);
}

main();

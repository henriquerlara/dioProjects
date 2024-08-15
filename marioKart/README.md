# Simulador de Corridas - Mario Kart com Node.js 🏎️🏁

Este projeto é um simulador de corridas inspirado no Mario Kart, criado com JavaScript e Node.js. O jogo simula uma competição entre dois personagens clássicos, Mario e Waluigi, com direito a itens aleatórios, confrontos, eventos especiais e muito mais!

## 🎮 Como Funciona

O jogo se baseia em um sistema de voltas e rodadas. A cada rodada, os personagens enfrentam diferentes desafios e podem coletar itens para ganhar vantagens ou atrapalhar o adversário. Tudo no jogo é gerado de forma aleatória, desde o bloco sorteado até os itens coletados.

### ⚙️ Mecânicas do Jogo

- **Blocos Aleatórios**: Em cada rodada, um bloco aleatório é sorteado:
  - **Reta**: Desafio baseado em velocidade.
  - **Curva**: Desafio baseado em manobrabilidade.
  - **Confronto**: Testa o poder dos personagens em uma batalha direta.
  - **Evento Especial**: Eventos imprevisíveis que afetam a corrida (ex: turbo, armadilha de areia, etc.).

- **Itens Coletáveis**: Durante a corrida, os personagens podem coletar itens como:
  - **Cogumelo**: Aumenta temporariamente a velocidade.
  - **Casca de Banana**: Reduz a manobrabilidade do adversário.
  - **Estrela**: Torna o personagem invencível na próxima rodada.
  - **Relâmpago**: Diminui a velocidade de todos os participantes.

- **Sistema de Pontos**: A cada rodada, o personagem que tiver o maior resultado nos desafios (baseado na soma do dado e do atributo) ganha um ponto. Confrontos podem resultar na perda de pontos para o adversário.

### 🚀 Execução e Interface

O jogo é totalmente baseado em comandos e rodado pelo terminal, com os resultados de cada rodada sendo exibidos no console. Todos os elementos, desde os blocos até os resultados dos dados e itens, são gerados aleatoriamente, proporcionando uma experiência única a cada partida.

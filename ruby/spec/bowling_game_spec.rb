require 'bowling_game'
require 'rspec/its'
require 'support/score_matcher'

describe BowlingGame do

  let(:game) {BowlingGame.new}

  context 'a new game' do
    it { expect(game.score).to eq 0 }
  end

end

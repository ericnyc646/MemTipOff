import { MarketplaceModule } from './marketplace.module';

describe('MarketplaceModule', () => {
  let marketplaceModule: MarketplaceModule;

  beforeEach(() => {
    marketplaceModule = new MarketplaceModule();
  });

  it('should create an instance', () => {
    expect(marketplaceModule).toBeTruthy();
  });
});

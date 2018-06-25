import { PublicwebmodModule } from './publicwebmod.module';

describe('PublicwebmodModule', () => {
  let publicwebmodModule: PublicwebmodModule;

  beforeEach(() => {
    publicwebmodModule = new PublicwebmodModule();
  });

  it('should create an instance', () => {
    expect(publicwebmodModule).toBeTruthy();
  });
});

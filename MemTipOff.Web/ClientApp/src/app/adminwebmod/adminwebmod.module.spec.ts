import { AdminwebmodModule } from './adminwebmod.module';

describe('AdminwebmodModule', () => {
  let adminwebmodModule: AdminwebmodModule;

  beforeEach(() => {
    adminwebmodModule = new AdminwebmodModule();
  });

  it('should create an instance', () => {
    expect(adminwebmodModule).toBeTruthy();
  });
});

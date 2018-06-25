import { UserwebmodModule } from './userwebmod.module';

describe('UserwebmodModule', () => {
  let userwebmodModule: UserwebmodModule;

  beforeEach(() => {
    userwebmodModule = new UserwebmodModule();
  });

  it('should create an instance', () => {
    expect(userwebmodModule).toBeTruthy();
  });
});

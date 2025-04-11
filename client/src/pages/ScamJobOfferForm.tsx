import { Field, Button, VStack, Input } from "@chakra-ui/react";

const ScamJobOfferForm: React.FC = () => {
  return (
    <VStack align="stretch" maxWidth="500px" margin="0 auto" padding={4}>
      <Field.Root>
        <Field.Label htmlFor="firstName">Eesnimi</Field.Label>
        <Input
          id="fullName"
          name="fullName"
          placeholder="Sisesta oma eesnimi"
        />
      </Field.Root>
      <Field.Root>
        <Field.Label htmlFor="lastName">Perekonnanimi</Field.Label>
        <Input
          id="fullName"
          name="fullName"
          placeholder="Sisesta oma perekonnanimi"
        />
      </Field.Root>

      <Field.Root>
        <Field.Label htmlFor="email">E-posti aadress</Field.Label>
        <Input
          id="email"
          name="email"
          type="email"
          placeholder="Sisesta oma e-posti aadress"
        />
      </Field.Root>

      <Field.Root>
        <Field.Label htmlFor="phone">Telefoninumber</Field.Label>
        <Input
          id="phone"
          name="phone"
          placeholder="Sisesta oma telefoninumber"
        />
      </Field.Root>

      <Field.Root>
        <Field.Label htmlFor="address">Aadress</Field.Label>
        <Input id="address" name="address" placeholder="Sisesta oma aadress" />
      </Field.Root>

      <Field.Root>
        <Field.Label htmlFor="previousJobs">
          Varasemad töökohad ja põhjused lahkumiseks
        </Field.Label>
        <Input
          id="previousJobs"
          name="previousJobs"
          placeholder="Sisesta varasemad töökohad"
        />
      </Field.Root>

      <Field.Root>
        <Field.Label htmlFor="idCard">
          Tee oma ID-kaardi esi- ja tagaküljest pilt ja lae üles
        </Field.Label>
        <Input border="none" id="idCard" name="idCard" type="file" />
        <Field.HelperText>(Tööandjale lepingu tegemiseks)</Field.HelperText>
      </Field.Root>

      <Button
        color="white"
        background="#b12df4"
        type="submit"
        borderRadius="30px"
      >
        Esita
      </Button>
    </VStack>
  );
};

export default ScamJobOfferForm;

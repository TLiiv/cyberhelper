import React, { useState, ChangeEvent, FormEvent } from "react";
import {
  Button,
  Input,
  Text,
  Box,
  Checkbox,
  Select,
  Portal,
  createListCollection,
} from "@chakra-ui/react";

// Define types for state variables
interface ScamDonationPageProps {}

const ScamDonationPage: React.FC<ScamDonationPageProps> = () => {
  const [email, setEmail] = useState<string>("");
  const [phone, setPhone] = useState<string>("");
  const [submitted, setSubmitted] = useState<boolean>(false);

  // Handle the form submission
  const handleSubmit = (e: FormEvent) => {
    e.preventDefault();
    setSubmitted(true);
  };

  // Handle input changes for email and phone fields
  const handleEmailChange = (e: ChangeEvent<HTMLInputElement>) => {
    setEmail(e.target.value);
  };

  const handlePhoneChange = (e: ChangeEvent<HTMLInputElement>) => {
    setPhone(e.target.value);
  };
  const makseviisid = createListCollection({
    items: [
      { label: "Pangaülekanne", value: "Pangaülekanne" },
      { label: "Krediitkaart", value: "Krediitkaart" },
      { label: "Paypal", value: "Paypal" },
    ],
  });

  return (
    <Box
      p={4}
      textAlign="center"
      width="100%"
      maxWidth="600px"
      margin="auto"
      alignItems="center"
    >
      <Box display="flex" flexDirection="column" alignItems="center">
        <Text mb={2} fontSize="xl" fontWeight="bold">
          Aitäh, et annetad Dharma Heategevusfondi !
        </Text>
        <Text fontSize="md" mt={4} width="50%">
          Annetuse kinnitamiseks täida palun järgmised väljad:
        </Text>

        <Box mt={4} width="50%">
          <Text mb={2} fontSize="md">
            Eesnimi
          </Text>
          <Input placeholder="Sisesta oma eesnimi" />
        </Box>
        <Box mt={4} width="50%">
          <Text mb={2} fontSize="md">
            Perekonnanimi
          </Text>
          <Input placeholder="Sisesta oma perekonnanimi" />
        </Box>

        <Box mt={4} width="50%">
          <Text mb={2} fontSize="md">
            Email Address
          </Text>
          <Input type="email" placeholder="Sisesta oma email" />
        </Box>

        <Box mt={4} width="50%">
          <Text mb={2} fontSize="md">
            Telefoni number
          </Text>
          <Input placeholder="Sisesta oma telefoni number" />
        </Box>
      </Box>
      <Box display="flex" justifyContent="center" width="50%" mx="auto">
        <Select.Root collection={makseviisid} size="md" width="100%">
          <Select.HiddenSelect />
          <Select.Label>Vali makseviis</Select.Label>
          <Select.Control>
            <Select.Trigger>
              <Select.ValueText placeholder="Vali makseviis" />
            </Select.Trigger>
            <Select.IndicatorGroup>
              <Select.Indicator />
            </Select.IndicatorGroup>
          </Select.Control>
          <Portal>
            <Select.Positioner>
              <Select.Content>
                {makseviisid.items.map((method) => (
                  <Select.Item item={method} key={method.value}>
                    {method.label}
                    <Select.ItemIndicator />
                  </Select.Item>
                ))}
              </Select.Content>
            </Select.Positioner>
          </Portal>
        </Select.Root>
      </Box>

      <Box mt={4}>
        <Checkbox.Root>
          <Checkbox.HiddenInput />
          <Checkbox.Control />
          <Checkbox.Label>Olen tingimustega nõus</Checkbox.Label>
        </Checkbox.Root>
      </Box>

      <Box mt={6}>
        <Button width="30%" onSubmit={handleSubmit} disabled>
          Anneta
        </Button>
      </Box>

      {submitted && (
        <Text mt={6} color="green.500">
          Your donation is being processed! Please check your email for
          confirmation.
        </Text>
      )}
    </Box>
  );
};

export default ScamDonationPage;
